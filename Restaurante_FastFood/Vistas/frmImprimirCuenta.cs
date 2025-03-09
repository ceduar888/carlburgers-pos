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
    public partial class frmImprimirCuenta : Form
    {
        DataBase_RestaurantEntities Entity = new DataBase_RestaurantEntities();
        private int numeroOrden;
        public frmImprimirCuenta(int numOrden)
        {
            InitializeComponent();
            numeroOrden = numOrden;

            txtIdOrden.Text = numOrden.ToString();
        }

        private void frmImprimirCuenta_Load(object sender, EventArgs e)
        {
            this.MostrarDetalle();
            dtgvDetalleProd.ReadOnly = true;
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

        private void dtgvDetalleProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvDetalleProd.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgvDetalleProd.SelectedRows[0];
                this.txtIdOrden.Text = filaSeleccionada.Cells["Orden"].Value.ToString();

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
                MessageBox.Show("ERROR: Total no encontrado", "Buscar total", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Factura.CreaTicket Ticket1 = new Factura.CreaTicket();

            Ticket1.TextoCentro("Mr. Carls Burgers"); //imprime una linea de descripcion
            Ticket1.TextoCentro("**********************************");

            Ticket1.TextoIzquierda("", "");
            Ticket1.TextoCentro("Ticket"); //imprime una linea de descripcion
            Ticket1.TextoIzquierda("No Orden: ", txtIdOrden.Text);
            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString(), "");
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
            Ticket1.TextoCentro(" ");
            Ticket1.TextoCentro("****NO ES VALIDO COMO TICKET DE PAGO****");


            // Ticket1.LineasTotales(); // imprime linea 

            string impresora = "Microsoft XPS Document Writer";
            Ticket1.ImprimirTiket(impresora);

            MessageBox.Show("Ticket se imprimió correctamente");

            this.Close();
        }

        private void txtBuscarOrden_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscarOrden.Text;
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
    }
}
