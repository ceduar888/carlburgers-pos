using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante_FastFood.Vistas
{
    public partial class frmMesas : Form
    {
        private frmMesa1 formMesa1;
        private frmMesa2 formMesa2;
        private frmMesa3 formMesa3;
        private frmMesa4 formMesa4;
        private frmMesa5 formMesa5;

        private string nomUsuario;
        public frmMesas(string codUsuario)
        {
            InitializeComponent();
            this.nomUsuario = codUsuario;
        }

        private void frmMesas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataBase_RestaurantDataSet1.Mesa' Puede moverla o quitarla según sea necesario.
            this.mesaTableAdapter.Fill(this.dataBase_RestaurantDataSet1.Mesa);

        }

        // METODOS
        private void MostrarFrmMesa1()
        {
            if(formMesa1 == null)
            {
                string nombreUsuario = nomUsuario;
                int numMesa = 1;
                formMesa1 = new frmMesa1(nombreUsuario, numMesa);
                formMesa1.Show();
            }
            else
            {
                formMesa1.Show();
            }            
            
        }

        private void MostrarFrmMesa2()
        {
            if (formMesa2 == null)
            {
                string nombreUsuario = nomUsuario;
                int numMesa = 2;
                formMesa2 = new frmMesa2(nombreUsuario, numMesa);
                formMesa2.Show();
            }
            else
            {
                formMesa2.Show();
            }
        }

        private void MostrarFrmMesa3()
        {
            if (formMesa3 == null)
            {
                string nombreUsuario = nomUsuario;
                int numMesa = 3;
                formMesa3 = new frmMesa3(nombreUsuario, numMesa);
                formMesa3.Show();
            }
            else
            {
                formMesa3.Show();
            }
        }
        private void MostrarFrmMesa4()
        {
            if (formMesa4 == null)
            {
                string nombreUsuario = nomUsuario;
                int numMesa = 4;
                formMesa4 = new frmMesa4(nombreUsuario, numMesa);
                formMesa4.Show();
            }
            else
            {
                formMesa4.Show();
            }
        }

        private void MostrarFrmMesa5()
        {
            if (formMesa5 == null)
            {
                string nombreUsuario = nomUsuario;
                int numMesa = 5;
                formMesa5 = new frmMesa5(nombreUsuario, numMesa);
                formMesa5.Show();
            }
            else
            {
                formMesa5.Show();
            }
        }

        private void CambiarColorBotonMesa(string nombreMesa, Color color)
        {
            // Construir el nombre del botón
            string nombreBoton = "btnMesa" + nombreMesa; // Eliminar espacios para coincidir con el nombre del botón

            // Buscar el botón por su nombre
            var boton = Controls.Find(nombreBoton, true).FirstOrDefault() as Button;

            if (boton != null)
            {
                // Cambiar el color del botón
                boton.BackColor = color;
            }
        }

        // EVENTOS  
        private void btnMesa1_Click(object sender, EventArgs e)
        {
            this.MostrarFrmMesa1();
        }

        private void btnMesa2_Click(object sender, EventArgs e)
        {
            this.MostrarFrmMesa2();
        }

        private void btnMesa3_Click(object sender, EventArgs e)
        {
            this.MostrarFrmMesa3();
        }

        private void btnMesa4_Click(object sender, EventArgs e)
        {
            this.MostrarFrmMesa4();
        }

        private void btnMesa5_Click(object sender, EventArgs e)
        {
            this.MostrarFrmMesa5();
        }

      
        // Eventos para cambiar el color de los botones de las mesas segun se asigne o libere  
        private void cmbAsignarMesa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string mesaSeleccionada = cmbAsignarMesa.SelectedItem.ToString();
            CambiarColorBotonMesa(mesaSeleccionada, Color.Red);
        }

        private void cmbLiberarMesa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string mesaSeleccionada = cmbLiberarMesa.SelectedItem.ToString();
            CambiarColorBotonMesa(mesaSeleccionada, Color.Green);
        }

        

        private void btnSalirMesa_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmMesas_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

    }
}
