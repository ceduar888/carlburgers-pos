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
    public partial class frmFacturaTicketLlevar : Form
    {
        private int idEmpleado;
        private int idOrden;
        public frmFacturaTicketLlevar(int empleado, int orden)
        {
            InitializeComponent();
            idEmpleado = empleado;
            idOrden = orden;
        }

        private void frmFacturaTicketLlevar_Load(object sender, EventArgs e)
        {

        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            int empleado = idEmpleado;
            int orden = idOrden;

            frmAgregarClienteLlevar fACLlevar = new frmAgregarClienteLlevar(empleado, orden);
            fACLlevar.Show();

            this.Close();

        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            int empleado = idEmpleado;
            int orden = idOrden;

            frmCobrarTicketLlevar fCTLlevar = new frmCobrarTicketLlevar(empleado, orden);
            fCTLlevar.Show();

            this.Close();
        }
    }
}
