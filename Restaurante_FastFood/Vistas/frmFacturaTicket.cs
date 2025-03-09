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
    public partial class frmFacturaTicket : Form
    {
        private string nomUsuario;
        public frmFacturaTicket(string nombreUsuario)
        {
            InitializeComponent();
            nomUsuario = nombreUsuario;
        }

        private void frmFacturaTicket_Load(object sender, EventArgs e)
        {

        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            string nombreUsuario = nomUsuario;
            frmAgregarCliente fACliente = new frmAgregarCliente(nombreUsuario);
            fACliente.Show();
            this.Close();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            string nombreUsuario = nomUsuario;
            frmCobrarTicket fCTicket = new frmCobrarTicket(nombreUsuario);
            fCTicket.Show();
            this.Close();
        }
    }
}
