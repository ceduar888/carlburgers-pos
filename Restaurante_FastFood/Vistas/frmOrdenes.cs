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
    public partial class frmOrdenes : Form
    {
        private static frmOrdenes instanciaActual;
        private List<DetallePedido> prodPendientes = new List<DetallePedido>();
        
        public frmOrdenes()
        {
            InitializeComponent();
            instanciaActual = this;
            
        }

        private void frmOrdenes_Load(object sender, EventArgs e)
        {
            ColumnasDataGridViewPendientes();
            Mostrar();
            ColumnasDataGridViewListos();

            dtgvListos.ReadOnly = true;
            dtgvPendientes.ReadOnly = true;
        }

        private void ColumnasDataGridViewPendientes()
        {
            // Limpiar las columnas existentes en el DataGridView
            dtgvPendientes.Columns.Clear();

            dtgvPendientes.Columns.Add("codPlatillo", "ID");
            dtgvPendientes.Columns.Add("nombrePlatillo", "Nombre Producto");
            dtgvPendientes.Columns.Add("cantidad", "Cantidad");
            dtgvPendientes.Columns.Add("subTotal", "Subtotal");
            dtgvPendientes.Columns.Add("codMesa", "Código Mesa");
            dtgvPendientes.Columns.Add("codOrden", "Código Orden");
        }

        private void ColumnasDataGridViewListos()
        {
            // Limpiar las columnas existentes en el DataGridView
            dtgvListos.Columns.Clear();

            dtgvListos.Columns.Add("codPlatillo", "ID");
            dtgvListos.Columns.Add("nombrePlatillo", "Nombre Producto");
            dtgvListos.Columns.Add("cantidad", "Cantidad");
            dtgvListos.Columns.Add("subTotal", "Subtotal");
            dtgvListos.Columns.Add("codMesa", "Código Mesa");
            dtgvListos.Columns.Add("codOrden", "Código Orden");
        }

        private void Mostrar()
        {
            dtgvPendientes.Rows.Clear();
            Platillo nuevoPlatillo = new Platillo();
            RPlatillo objRPlatillo = new RPlatillo();

            foreach (var productoPendiente in prodPendientes)
            {
                int idPlatillo = (int)productoPendiente.codPlatillo;

                string nombrePlatillo = objRPlatillo.ObtenerNombrePlatillo(idPlatillo);

                dtgvPendientes.Rows.Add(
                    productoPendiente.codPlatillo,
                    nombrePlatillo,
                    productoPendiente.cantidad,
                    productoPendiente.subTotal,
                    productoPendiente.codMesa,
                    productoPendiente.codOrden
                );

            }
        }

        public void RecibirLista(DetallePedido nuevoDetalle)
        {
            DetallePedido nuevo = new DetallePedido();
            nuevo = nuevoDetalle;           
            prodPendientes.Add(nuevo);

            ColumnasDataGridViewPendientes();
            Mostrar();
        }

        public void RecibirRol(int rol)
        {
            if(rol == 2)
            {
                panelListo.Visible = false;
                panelEntregado.Visible = true;
            }
            else if(rol == 3)
            {
                panelListo.Visible = false;
                panelEntregado.Visible = true;
            }
            else if(rol == 4)
            {
                panelListo.Visible = true;
                panelEntregado.Visible = false;
            }
            else
            {
                panelListo.Visible = true;
                panelEntregado.Visible = true;
            }
        }

        // Metdodo para saber si este formulario ya esta abierto o no.
        // Si esta abierto, abre la instancia ya abierta y si no abre una nueva
        public static frmOrdenes ObtenerInstancia()
        {
            return instanciaActual;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dtgvPendientes.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada en dtgvPendientes
                DataGridViewRow selectedRow = dtgvPendientes.SelectedRows[0];

                // Copiar datos de la fila seleccionada a dtgvListos
                DataGridViewRow newRow = (DataGridViewRow)selectedRow.Clone();
                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    newRow.Cells[cell.ColumnIndex].Value = cell.Value;
                }

                // Agregar la nueva fila a dtgvListos
                dtgvListos.Rows.Add(newRow);

                // Eliminar la fila seleccionada de dtgvPendientes
                dtgvPendientes.Rows.Remove(selectedRow);
            }
            else
            {
                MessageBox.Show("Seleccione un producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEntregado_Click(object sender, EventArgs e)
        {
            if (dtgvListos.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada en dtgvPendientes
                DataGridViewRow selectedRow = dtgvListos.SelectedRows[0];

                // Eliminar la fila seleccionada de dtgvPendientes
                dtgvListos.Rows.Remove(selectedRow);
            }
            else
            {
                MessageBox.Show("Seleccione un producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtgvPendientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
