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
    public partial class frmAgregarCliente : Form
    {
        RCliente objRCliente = new RCliente();
        Cliente objCliente = new Cliente();

        private string nomUsuario;
        public frmAgregarCliente(string nombreUsuario)
        {
            InitializeComponent();
            nomUsuario = nombreUsuario;
        }

        private void frmAgregarCliente_Load(object sender, EventArgs e)
        {
            MostrarClientes();
            dtgvDatosCliente.ReadOnly = true;
        }


        // METODOS PRINCIPALES
        private void MostrarClientes()
        {
            List<Cliente> cliente = objRCliente.GetAll();

            dtgvDatosCliente.DataSource = cliente;

            dtgvDatosCliente.Columns["idCliente"].HeaderText = "N° Cliente";
            dtgvDatosCliente.Columns["nombreCliente"].HeaderText = "Nombres";
            dtgvDatosCliente.Columns["apellidoCliente"].HeaderText = "Apellidos";
            dtgvDatosCliente.Columns["direccionCliente"].HeaderText = "Direccion";
            dtgvDatosCliente.Columns["duiCliente"].HeaderText = "DUI";
            dtgvDatosCliente.Columns["telefonoCliente"].HeaderText = "Telefono";

            dtgvDatosCliente.Columns["Orden"].Visible = false;
        }

        private void AgregarCliente()
        {

            objCliente.nombreCliente = txtNombreCliente.Text;
            objCliente.apellidoCliente = txtApellidosCliente.Text;
            objCliente.duiCliente = txtDuiCliente.Text;
            objCliente.direccionCliente = txtDireccion.Text;
            objCliente.telefonoCliente = txtTelefonoCliente.Text;

            int respuesta = objRCliente.Create(objCliente);

            respuesta.ToString();
            if (respuesta != -1)
            {
                MessageBox.Show("Cliente registrado exitosamente", "Registro de cliente",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarClientes();
            }
            else
            {
                MessageBox.Show("ERROR: cliente no ingresador", "Registro de cliente",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        // EVENTOS
        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombreCliente.Text;
                string apellido = txtApellidosCliente.Text;
                string direccion = txtDireccion.Text;
                string dui = txtDuiCliente.Text;
                string telefono = txtTelefonoCliente.Text;

                if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(direccion) || string.IsNullOrWhiteSpace(dui)
                    || string.IsNullOrWhiteSpace(telefono))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios antes de registrar.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    AgregarCliente();
                }

                string nombreUsuario = nomUsuario;
                string nomCliente = txtNombreCliente.Text;
                string apeCliente = txtApellidosCliente.Text;
                string duiCliente = txtDuiCliente.Text;
                string telCliente = txtTelefonoCliente.Text;

                frmCobrarFactura fCobrar = new frmCobrarFactura(nombreUsuario, nomCliente, apeCliente, duiCliente, telCliente);
                fCobrar.Show();

                this.Close();
            }
            catch
            {
                MessageBox.Show("ERROR: Ocurrió un error", "Registrar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dtgvDatosCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvDatosCliente.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgvDatosCliente.SelectedRows[0];
                this.txtIdCliente.Text = filaSeleccionada.Cells["idCliente"].Value.ToString();
                this.txtNombreCliente.Text = filaSeleccionada.Cells["nombreCliente"].Value.ToString();
                this.txtApellidosCliente.Text = filaSeleccionada.Cells["apellidoCliente"].Value.ToString();
                this.txtDireccion.Text = filaSeleccionada.Cells["direccionCliente"].Value.ToString();
                this.txtDuiCliente.Text = filaSeleccionada.Cells["duiCliente"].Value.ToString();
                this.txtTelefonoCliente.Text = filaSeleccionada.Cells["telefonoCliente"].Value.ToString();
            }
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscarCliente.Text.ToLower();

            List<Cliente> clientes = objRCliente.GetAll();

            // Filtrar los clientes
            List<Cliente> clientesFiltrados = clientes.Where(c => c.nombreCliente.ToLower().Contains(filtro) || c.duiCliente.Contains(filtro)).ToList();
            dtgvDatosCliente.DataSource = clientesFiltrados;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreUsuario = nomUsuario;
                string nomCliente = txtNombreCliente.Text;
                string apeCliente = txtApellidosCliente.Text;
                string duiCliente = txtDuiCliente.Text;
                string telCliente = txtTelefonoCliente.Text;

                frmCobrarFactura fCobrar = new frmCobrarFactura(nombreUsuario, nomCliente, apeCliente, duiCliente, telCliente);
                fCobrar.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR: Ocurrió un error al intentar enviar los datos del cliente", "Agregar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

       
    }
}
