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
    public partial class frmMesa1 : Form
    {
        private frmOrdenes fOrdenes;
        // Objetos de los modelos necesarios 
        Orden objOrden = new Orden();

        //Objetos de las clases Repositorio necesarios
        ROrden objROrden = new ROrden();
        RPlatillo objRPlatillo = new RPlatillo();
        RUsuario objRUsuario = new RUsuario();
        RDetallePedido objRDetallePedido = new RDetallePedido();
      
        // Lista que acumula los productos que se van añadiendo a la orden
        private List<DetallePedido> productosPendientes = new List<DetallePedido>();

        private int numeroMesa;
        private string nomUsuario;
        private double totalAcumulado = 0;
        public frmMesa1(string nombreUsuario, int numMesa)
        {
            InitializeComponent();
            this.numeroMesa = numMesa;
            this.nomUsuario = nombreUsuario;
        }

        private void frmMesa1_Load(object sender, EventArgs e)
        {
            dtgvAgregarProductos.ReadOnly = true;
            dtgvPlatillos.ReadOnly = true;

            // TODO: esta línea de código carga datos en la tabla 'dataBase_RestaurantDataSet2.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.dataBase_RestaurantDataSet2.Categoria);

            // El estado de la orden sera invisible ya que siemple la orden comienza con el valor "pendiente"
            txtEstadoOrden.Visible = false;
            txtPrecioPlatillo.Visible = false;
            txtNumeroMesa.Text = numeroMesa.ToString();
            txtNumeroMesa.Visible = false;

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

            this.MostrarPlatillo();
            this.ColumnasDataGridView();
        }

        // METODOS PRINCIPALES  

        // MOSTRAR LOS PLATILLOS Y LOS PRODUCTOS QUE SE VAN A AGREGAR
        private void MostrarPlatillo()
        {
            List<Platillo> platillos = objRPlatillo.GetAll();

            dtgvPlatillos.DataSource = platillos;

            dtgvPlatillos.Columns["idPlatillo"].HeaderText = "ID";
            dtgvPlatillos.Columns["nombrePlatillo"].HeaderText = "Nombre";
            dtgvPlatillos.Columns["precioPlatillo"].HeaderText = "Precio";
            dtgvPlatillos.Columns["descPlatillo"].HeaderText = "Descripcion";
            dtgvPlatillos.Columns["codCategoria"].HeaderText = "ID Categoria";

            dtgvPlatillos.Columns["Categoria"].Visible = false;
            dtgvPlatillos.Columns["DetallePedido"].Visible = false;
        }

        // Definiendo columnas del datagridview.
        private void ColumnasDataGridView()
        {
            // Limpiar las columnas existentes en el DataGridView
            dtgvAgregarProductos.Columns.Clear();

            dtgvAgregarProductos.Columns.Add("codPlatillo", "ID");
            dtgvAgregarProductos.Columns.Add("nombrePlatillo", "Nombre Producto");
            dtgvAgregarProductos.Columns.Add("cantidad", "Cantidad");
            dtgvAgregarProductos.Columns.Add("subTotal", "Subtotal");
            dtgvAgregarProductos.Columns.Add("codMesa", "Código Mesa");
            dtgvAgregarProductos.Columns.Add("codOrden", "Código Orden");
        }

        private void MostrarVistaPrevia()
        {
            dtgvAgregarProductos.Rows.Clear();
            Platillo nuevoPlatillo = new Platillo();

            foreach (var productoPendiente in productosPendientes)
            {
                int idPlatillo = (int)productoPendiente.codPlatillo;

                string nombrePlatillo = objRPlatillo.ObtenerNombrePlatillo(idPlatillo);

                dtgvAgregarProductos.Rows.Add(
                    productoPendiente.codPlatillo,
                    nombrePlatillo,
                    productoPendiente.cantidad,
                    productoPendiente.subTotal,
                    productoPendiente.codMesa,
                    productoPendiente.codOrden
                );

            }
        }

        // AGREGAR PLATILLOS QUE VAN A IR A LA ORDEN, EL CLIENTE Y LA ORDEN
        private void AgregarPlatilloADetalle()
        {
            // Nuevo objeto de DetallePedido
            DetallePedido nuevoDetallePedido = new DetallePedido();

            nuevoDetallePedido.cantidad = int.Parse(txtCantidad.Text);
            nuevoDetallePedido.codPlatillo = int.Parse(txtIdPlatillo.Text);
            double precio = double.Parse(txtPrecioPlatillo.Text);
            double cantidad = double.Parse(txtCantidad.Text);
            nuevoDetallePedido.subTotal = precio * cantidad;
            nuevoDetallePedido.codMesa = int.Parse(txtNumeroMesa.Text);

            if (fOrdenes == null)
            {
                fOrdenes = new frmOrdenes();
                fOrdenes.RecibirLista(nuevoDetallePedido);
                
            }
            else
            {
                fOrdenes.RecibirLista(nuevoDetallePedido);
            }

            productosPendientes.Add(nuevoDetallePedido);


            totalAcumulado += nuevoDetallePedido.subTotal;

            lbTotal.Text = totalAcumulado.ToString();

            MostrarVistaPrevia();
           
    }

        private void AgregarOrden()
        {
            objOrden.codMesa = int.Parse(txtNumeroMesa.Text);
            objOrden.tipoOrden = txtTipoOrden.Text;
            objOrden.fechaOrden = dateOrden.Value;
            objOrden.estadoOrden = txtEstadoOrden.Text;
            objOrden.totalOrden = double.Parse(lbTotal.Text);
            objOrden.codEmpleado = int.Parse(txtIdEmpleado.Text);

            int respuesta = objROrden.Create(objOrden);

            if (respuesta != -1)
            {
                MessageBox.Show("Orden registrada exitosamente", "Registro de ordenes",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ERROR: ocurrio algo al ingresar la orden", "Registro de ordenes",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegistarOrden()
        {
            // Se comprueban textbox y combobox vacios
            string total = lbTotal.Text;
            if (string.IsNullOrWhiteSpace(total))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                this.AgregarOrden();
            }
        }

        private void RegistrarPlatillos()
        {
            try
            {
                Orden nuevoOrden = new Orden();

                nuevoOrden.totalOrden = double.Parse(lbTotal.Text);
                int codObtenido = objROrden.ObtenerOrden(nuevoOrden.totalOrden);

                // Asigna el código de la orden a cada producto en la lista
                foreach (var producto in productosPendientes)
                {
                    producto.codOrden = codObtenido;
                }
                // Intenta registrar todos los platillos pendientes
                int respuestaDetallePedido = objRDetallePedido.Create(productosPendientes);

                if (respuestaDetallePedido != -1)
                {
                    productosPendientes.Clear();

                    this.MostrarVistaPrevia();

                }
                else
                {
                    MessageBox.Show("ERROR: no se pudo agregar el producto", "Registro de producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("ERROR: Ocurrió un problema al hacer el pedido", "Hacer Pedido",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // METODOS SECUNDARIOS
        private void LimpiarCampos()
        {
            cmbCategoriaProd.SelectedIndex = -1;
            txtCantidad.Clear();
        }


        private void FiltroComboBoxCategoria()
        {
            List<Platillo> platillos = objRPlatillo.GetAll();

            if (cmbCategoriaProd.SelectedValue != null)
            {
                int codigoCategoriaSeleccionada = (int)cmbCategoriaProd.SelectedValue;

                // Filtrar los platillos en la lista
                var platillosFiltrados = platillos.Where(platillo => platillo.codCategoria == codigoCategoriaSeleccionada).ToList();

                // Asignar los resultados al DataGridView
                dtgvPlatillos.DataSource = platillosFiltrados;
            }
        }


        // EVENTOS
        private void dtgvPlatillos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvPlatillos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgvPlatillos.SelectedRows[0];
                this.txtIdPlatillo.Text = filaSeleccionada.Cells["idPlatillo"].Value.ToString();
                this.txtPrecioPlatillo.Text = filaSeleccionada.Cells["precioPlatillo"].Value.ToString();
            }
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            // Comprobamos que se halla seleccionado un producto para agregar
            if (!string.IsNullOrEmpty(txtIdPlatillo.Text))
            {
                // Comprobamos que el textbox de cantidad 
                string cantidad = txtCantidad.Text;

                if (string.IsNullOrWhiteSpace(cantidad))
                {
                    MessageBox.Show("ERROR: Tiene que ingresar la cantidad y la mesa para agregar un producto", "Registro de ordenes",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.AgregarPlatilloADetalle();
                }
                
                // Limpiamos el textbox
                txtCantidad.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para agregar.", "Agregar producto",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHacerPedido_Click(object sender, EventArgs e)
        {
            try
            {

                // Registramos la orden
                this.RegistarOrden();

                // Registramos los platillos
                this.RegistrarPlatillos();
                //Limpiamos Campos
                this.LimpiarCampos();

                // Se busca el id de la Orden para enviarla al formulario que genera el ticket
                Orden nuevoOrden = new Orden();

                nuevoOrden.totalOrden = double.Parse(lbTotal.Text);
                int numOrden = objROrden.ObtenerOrden(nuevoOrden.totalOrden);

                lbTotal.Text = "Cantidad";
                // Reiniciamos el contador a cero otra vez
                totalAcumulado = 0;

                // Se envia el numero de orden para imprimir la cuenta
                frmImprimirCuenta objImprimir = new frmImprimirCuenta(numOrden);
                objImprimir.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Error al hacer el pedido. El pedido no se completó correctamente.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


           
        }

        private void btnEliminarProd_Click(object sender, EventArgs e)
        {
            if (dtgvAgregarProductos.SelectedRows.Count > 0)
            {
                int rowIndex = dtgvAgregarProductos.SelectedRows[0].Index;

                // Obtener el codPlatillo de la fila seleccionada
                int codPlatillo = (int)dtgvAgregarProductos.Rows[rowIndex].Cells["codPlatillo"].Value;

                DetallePedido productoEliminar = productosPendientes.FirstOrDefault(p => p.codPlatillo == codPlatillo);

                if (productoEliminar != null)
                {
                    productosPendientes.Remove(productoEliminar);

                    MostrarVistaPrevia();

                    // Actualizar el total acumulado después de eliminar el producto
                    totalAcumulado -= productoEliminar.subTotal = 0;
                    lbTotal.Text = totalAcumulado.ToString();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar.", "Eliminar Producto",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalirNuevaOrden_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cmbCategoriaProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FiltroComboBoxCategoria();
        }

        private void frmMesa1_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void dtgvAgregarProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
