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
    public partial class frmInicioSesion : Form
    {
        private RUsuario objRUsuario = new RUsuario();
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            
        }

        public void Login()
        {
            Usuario objUsuario = new Usuario();
            objUsuario.nombreUsuario = this.txtInicioUsuario.Text;
            objUsuario.passwordUsuario = this.txtInicioContrasenia.Text;
            

            bool response = objRUsuario.login(objUsuario);
            if (response)
            {
                // Obtener el rol del usuario para mostrar u ocultar opciones en el fromulario Home.
                int rolUsuario = objRUsuario.RolDelUsuario(objUsuario.nombreUsuario);
                frmHome objFHome = new frmHome(rolUsuario, objUsuario.nombreUsuario);
                
                objFHome.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos",
                    "Error en el inicio de sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void frmInicioSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void frmInicioSesion_Shown_1(object sender, EventArgs e)
        {
            this.txtInicioUsuario.Focus();
        }
    }
}
