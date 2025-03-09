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
    public partial class frmCobrarTicket : Form
    {
        DataBase_RestaurantEntities Entity = new DataBase_RestaurantEntities();
        private string nomUsuario;
        public frmCobrarTicket(string nombreUsuario)
        {
            InitializeComponent();
            nomUsuario = nombreUsuario;
        }

        private void frmCobrarTicket_Load(object sender, EventArgs e)
        {
            panelEfectivo.Visible = false;

            txtIdDetalle.Visible = false;

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

        // METODOS

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


        private void RegistrarOrdenPagada()
        {
            int idOrden = int.Parse(txtIdOrden.Text);
            ROrden nuevoOrden = new ROrden();

            int respuesta = nuevoOrden.OrdenPagada(idOrden);

            if (respuesta != -1)
            {
                // No mostramos nada
            }
            else
            {
                MessageBox.Show("ERROR: No se puedo pagar la orden", "Pagar orden", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerarTicket()
        {
            Factura.CreaTicket Ticket1 = new Factura.CreaTicket();

            Ticket1.TextoCentro("Mr. Carls Burgers"); //imprime una linea de descripcion
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoIzquierda("Boulevar Miramonte, 1ra Avenida Norte, #578", " ");
            Ticket1.TextoIzquierda("NIT:", "0928-277400-698-1");
            Ticket1.TextoIzquierda("Giro:", "Restaurantes de comida rápida");
            Ticket1.TextoIzquierda("Teléfono:", "2777-1015");
            Ticket1.TextoIzquierda("", "");
            Ticket1.TextoCentro("Ticket"); //imprime una linea de descripcion
            Ticket1.TextoIzquierda("No Ticket: ", txtIdDetalle.Text);
            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString(), "");
            Ticket1.TextoIzquierda("Cajero N°: ", txtIdEmpleado.Text);
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

            if (cmbTipoPago.Text == "Efectivo")
            {
                Factura.CreaTicket.LineasGuion();
                Ticket1.TextoIzquierda("Pago: ", "Efectivo");
                Ticket1.TextoIzquierda(" ", " ");
                Ticket1.AgregaTotales("Total", double.Parse(lblTotalPagar.Text)); // imprime linea con total
                Ticket1.TextoIzquierda(" ", " ");
                Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(txtEntrega.Text));
                Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(lblCambio.Text));
            }
            else
            {
                Factura.CreaTicket.LineasGuion();
                Ticket1.TextoIzquierda("Pago: ", "Tarjeta");
                Ticket1.TextoIzquierda(" ", " ");
                Ticket1.AgregaTotales("Total", double.Parse(lblTotalPagar.Text)); // imprime linea con total
                Ticket1.TextoIzquierda(" ", " ");
            }


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

        // EVENTOS
        private void dtgvDetalleProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgvDetalleProd.SelectedRows.Count > 0)
                {
                    DataGridViewRow filaSeleccionada = dtgvDetalleProd.SelectedRows[0];
                    this.txtIdOrden.Text = filaSeleccionada.Cells["Orden"].Value.ToString();
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
                    MessageBox.Show("ERROR: Total no encontrado", "Buscar total", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("ERROR: No se pudo seleccionar la fila", "Seleccionar Orden", MessageBoxButtons.OK);
            }
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text;
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
                double clienteEntrega = double.Parse(txtEntrega.Text);
                double totalOrden = double.Parse(lblTotalPagar.Text);

                double cambio = clienteEntrega - totalOrden;
                lblCambio.Text = cambio.ToString();
            }
            catch
            {
                MessageBox.Show("No se pudo calcular el cambio");
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            try
            {
                string tipoPago = cmbTipoPago.Text;

                if (string.IsNullOrWhiteSpace(tipoPago))
                {
                    MessageBox.Show("Elija el tipo de pago", "Generar factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (cmbTipoPago.Text == "Efectivo")
                    {
                        string cambio = txtEntrega.Text;
                        if (string.IsNullOrWhiteSpace(cambio))
                        {
                            MessageBox.Show("Digite cuanto entrega le cliente", "Generar factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            // Registrara la orden como pagada
                            this.RegistrarOrdenPagada();

                            // Metodo para generar factura
                            this.GenerarTicket();
                        }
                    }
                    else
                    {
                        // Registrara la orden como pagada
                        this.RegistrarOrdenPagada();

                        // Metodo para generar factura
                        this.GenerarTicket();

                    }
                }

            }
            catch
            {
                MessageBox.Show("ERROR: Ocurrió un error al intentar generar el ticket", "Gererar ticket", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoPago.Text == "Efectivo")
            {
                panelEfectivo.Visible = true;
            }
            else if (cmbTipoPago.Text == "Tarjeta")
            {
                panelEfectivo.Visible = false;
            }
        }
    }
}
