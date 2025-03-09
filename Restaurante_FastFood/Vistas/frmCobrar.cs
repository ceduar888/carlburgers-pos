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
    public partial class frmCobrar : Form
    {
        DataBase_RestaurantEntities Entity = new DataBase_RestaurantEntities();
        RDetallePedido objRDetallePedido = new RDetallePedido();
        DetallePedido objDetallePedido = new DetallePedido();

        // Variable para almacenar el nombre de usuario logeado
        private string nomUsuario;
        public frmCobrar(string nombreUsuario)
        {
            InitializeComponent();
            nomUsuario = nombreUsuario;
        }

        private void frmCobrar_Load(object sender, EventArgs e)
        {
            txtIdCliente.Visible = false;

            RUsuario objRUsuario = new RUsuario();
            // Buscando el id del empleado logeado
            string usuario = nomUsuario;
            int idEmpleado = objRUsuario.IdEmpleado(usuario);

            if (idEmpleado != -1)
            {
                txtIdEmpleado.Text = idEmpleado.ToString();
            }
            else
            {
                MessageBox.Show("ERROR: No se encontro el ID del Empleado", "Registro de Ordenes",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.MostrarDetalle();
           
        }

        private void MostrarDetalle()
        {
            var query = from detalle in Entity.DetallePedido
                        join platillo in Entity.Platillo on detalle.codPlatillo equals platillo.idPlatillo
                        join orden in Entity.Orden on detalle.codOrden equals orden.idOrden  
                        select new
                        {
                            Producto = platillo.nombrePlatillo,
                            Precio = platillo.precioPlatillo,
                            Cantidad = detalle.cantidad,
                            SubTotal = detalle.subTotal,
                            Orden = detalle.codOrden,
                            Mesa = detalle.codMesa,
                            ID = detalle.idDetallePedido,
                            IDCliente = orden.codCliente
                        };

            dtgvDetalleProd.DataSource = query.ToList();
        }



        // METODOS SECUNDARIOS
        private void CalcularCambio()
        {
            double clienteEntrega = double.Parse(txtEntrega.Text);
            double total = double.Parse(lblTotalPagar.Text);
            double cambio = clienteEntrega - total;

            lblCambio.Text = cambio.ToString();
        }

        // EVENTOS
        private void dtgvDetalleProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvDetalleProd.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgvDetalleProd.SelectedRows[0];
                this.txtIdOrden.Text = filaSeleccionada.Cells["Orden"].Value.ToString();
                this.txtIdCliente.Text = filaSeleccionada.Cells["IDCliente"].Value.ToString();
                this.txtIdDetalle.Text = filaSeleccionada.Cells["ID"].Value.ToString();
            }

            // Buscamos el total de la orden con el codOrden
            ROrden objROrden = new ROrden();
            int codOrden = int.Parse(txtIdOrden.Text);
            double totalOrden = objROrden.ObtenerTotal(codOrden);
            // Se asigna el total de la orden al label
            if (totalOrden != -1)
            {
                lblTotalPagar.Text = totalOrden.ToString();
            }
            else
            {
                MessageBox.Show("ERROR: Total no encontrado","Buscar total", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Buscamos el nombre del cliente con el codCliente
            RCliente objRCliente = new RCliente();
            int codCliente = int.Parse(txtIdCliente.Text);
            string nomCliente = objRCliente.ObtenerNomCliente(codCliente);
            // Se asigna el nombre al textbox
            if (nomCliente != null)
            {
                txtNombreCliente.Text = nomCliente;
            }
            else
            {
                MessageBox.Show("ERROR: Nombre no encontrado", "Buscar nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcularCambio();
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscarCliente.Text;
            var queryfiltrada = from detalle in Entity.DetallePedido
                        join platillo in Entity.Platillo on detalle.codPlatillo equals platillo.idPlatillo
                        join orden in Entity.Orden on detalle.codOrden equals orden.idOrden
                        where detalle.codOrden.ToString().Contains(filtro)

                        select new
                        {
                            Producto = platillo.nombrePlatillo,
                            Precio = platillo.precioPlatillo,
                            Cantidad = detalle.cantidad,
                            SubTotal = detalle.subTotal,
                            Orden = detalle.codOrden,
                            Mesa = detalle.codMesa,
                            ID = detalle.idDetallePedido,
                            IDCliente = orden.codCliente
                        };

            dtgvDetalleProd.DataSource = queryfiltrada.ToList();
        }

        private void txtEntrega_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblCambio.Text = (double.Parse(txtEntrega.Text) - double.Parse(lblTotalPagar.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("No se pudo calcular el cambio");
            }
        }

        private void btnRegistrarEmpleado_Click(object sender, EventArgs e)
        {
            Factura.CreaTicket Ticket1 = new Factura.CreaTicket();

            Ticket1.TextoCentro("Mr. Carls Burgers"); //imprime una linea de descripcion
            Ticket1.TextoCentro("**********************************");

            Ticket1.TextoIzquierda("", "");
            Ticket1.TextoCentro("Ticket"); //imprime una linea de descripcion
            Ticket1.TextoIzquierda("No Ticket: ", txtIdDetalle.Text);
            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString(), "");
            Ticket1.TextoIzquierda("Empleado N°: ", txtIdEmpleado.Text);
            Ticket1.TextoIzquierda("", "");

            Factura.CreaTicket.LineasGuion();
            Factura.CreaTicket.EncabezadoVenta();
            Factura.CreaTicket.LineasGuion();
            foreach (DataGridViewRow r in dtgvDetalleProd.Rows)
            {
                string producto = r.Cells["Producto"].Value.ToString();
                double precio = double.Parse(r.Cells["Precio"].Value.ToString());
                int cantidad = int.Parse(r.Cells["Cantidad"].Value.ToString());
                double subtotal = double.Parse(r.Cells["SubTotal"].Value.ToString());

                Ticket1.AgregaArticulo(producto, precio, cantidad, subtotal);
            }


            Factura.CreaTicket.LineasGuion();
            Ticket1.TextoIzquierda(" ", " ");
            Ticket1.AgregaTotales("Total", double.Parse(lblTotalPagar.Text)); // imprime linea con total
            Ticket1.TextoIzquierda(" ", " ");
            Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(txtEntrega.Text));
            Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(lblCambio.Text));


            // Ticket1.LineasTotales(); // imprime linea 

            Ticket1.TextoIzquierda(" ", " ");
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoCentro("*     Gracias por preferirnos    *");

            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoIzquierda(" ", " ");
            string impresora = "Microsoft XPS Document Writer";
            Ticket1.ImprimirTiket(impresora);

            MessageBox.Show("Gracias por preferirnos");

            this.Close();
        }
    }
}
