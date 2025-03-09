using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using Clases.ModeloLogico;

namespace Restaurante_FastFood.Vistas
{
    public partial class frmHome : Form
    {
        private frmOrdenes fOrdenes;
        private frmMesas formularioMesas;
        private int rolObtenido;
        private string nomUsuario;
        public frmHome(int rolUsuario, string nombreUsuario)
        {
            InitializeComponent();
            // Valor entero del rol del usuario
            this.rolObtenido = rolUsuario;
            this.nomUsuario = nombreUsuario;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            // Proceso para obtener el rol del empleado y asi asignar las funciones 
            // que puede ver o no ver en el formulario principal
            RUsuario objRUsuario = new RUsuario();

            string nombreUsuario = nomUsuario;
            string nombreApellidoEmpleado = objRUsuario.NombreUsuario(nombreUsuario);

            if (!string.IsNullOrEmpty(nombreApellidoEmpleado))
            {
                lblNombreUsuario.Text = nombreApellidoEmpleado;
            }
            else
            {
                MessageBox.Show("Nombre del usuario no encontrado", "Buscar nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            panelMenuDesplegable.Visible = false;
         
            // Gerente
            if (rolObtenido == 1)
            {
                panelCobrar.Visible = true;
                panelTomarOrden.Visible = true;
                panelOrdenes.Visible = true;
                panelMesas.Visible = true;
                panelReportes.Visible = true;
                panelAdministrar.Visible = true;
            }
            // Cajero
            else if (rolObtenido == 2)
            {
                panelCobrar.Visible = true;
                panelTomarOrden.Visible = true;
                panelOrdenes.Visible = true;
                panelMesas.Visible = false;
                panelReportes.Visible = false;
                panelAdministrar.Visible = false;
            }
            // Mesero
            else if (rolObtenido == 3)
            {
                panelCobrar.Visible = false;
                panelTomarOrden.Visible = false;
                panelOrdenes.Visible = true;
                panelMesas.Visible = true;
                panelReportes.Visible = false;
                panelAdministrar.Visible = false;
            }
            else if(rolObtenido == 4)
            {
                panelCobrar.Visible = false;
                panelTomarOrden.Visible = false;
                panelOrdenes.Visible = true;
                panelMesas.Visible = false;
                panelReportes.Visible = false;
                panelAdministrar.Visible = false;
            }
        }


        // Metodo para volver al formulario de mesas sin perden configuracion
        private void MostrarFrmMesas()
        {
            
            if (formularioMesas == null)
            {
                // Si el formulario no está creado, créalo
                string nombreUsuario = nomUsuario;
                formularioMesas = new frmMesas(nombreUsuario);
                formularioMesas.Show();
            }
            else
            {
                // Si el formulario ya está creado, simplemente muéstralo
                formularioMesas.Show();
            }
        }

        // EVENTOS
        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            panelMenuDesplegable.Visible = true;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmCliente fCliente = new frmCliente();
            fCliente.Show();
            panelMenuDesplegable.Visible = false;
        }

        private void btnPlatillos_Click(object sender, EventArgs e)
        {
            frmPlatillo fPlatillo = new frmPlatillo();
            fPlatillo.Show();
            panelMenuDesplegable.Visible = false;
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult confirmarCerrarSesion = MessageBox.Show("¿Está seguro que desea cerrar la sesión?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmarCerrarSesion == DialogResult.Yes)
            {
                // Crear una copia de la lista de formularios abiertos
                List<Form> formulariosAbiertos = Application.OpenForms.Cast<Form>().ToList();

                // Cierra todos los formularios abiertos excepto el formulario principal
                foreach (Form form in formulariosAbiertos)
                {
                    if (form != this)
                    {
                        form.Close();
                    }
                }
                Application.Exit();
            }
        }

        private void bntEmpleados_Click(object sender, EventArgs e)
        {
            frmEmpleado fEmpleado = new frmEmpleado();
            fEmpleado.Show();
            panelMenuDesplegable.Visible = false;
        }

        private void btnTomarOrden_Click(object sender, EventArgs e)
        {
            string nombreUsuario = nomUsuario;
            frmTomarOrden fTOrden = new frmTomarOrden(nombreUsuario);
            fTOrden.Show();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = nomUsuario;
            frmFacturaTicket fTicket = new frmFacturaTicket(nombreUsuario);
            fTicket.Show();
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            this.MostrarFrmMesas();
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            frmOrdenes Ordenes = frmOrdenes.ObtenerInstancia();
            if(Ordenes == null)
            {
                int rol = rolObtenido;
                frmOrdenes fOrdenes = new frmOrdenes();
                fOrdenes.RecibirRol(rol);
                fOrdenes.Show();
            }
            else
            {
                int rol = rolObtenido;
                Ordenes.RecibirRol(rol);
                Ordenes.Show();
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportes fReportes = new frmReportes();
            fReportes.Show();
        }
    }
}
