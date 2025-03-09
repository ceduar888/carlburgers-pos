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
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.IO;
using iText.Kernel.Exceptions;

namespace Restaurante_FastFood.Vistas
{
    public partial class frmReportes : Form
    {
        private DataBase_RestaurantEntities Entity = new DataBase_RestaurantEntities();
        ROrden objROrden = new ROrden();
        public frmReportes()
        {
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            this.MostrarOrdenes();
            dtgvOrdenes.ReadOnly = true;

            lblTotal.Text = "Total: 0.0";
        }

        private void MostrarOrdenes()
        {
            List<Orden> ordenes = objROrden.GetAll();

            dtgvOrdenes.DataSource = ordenes;

            dtgvOrdenes.Columns["idOrden"].HeaderText = "N° Orden";
            dtgvOrdenes.Columns["fechaOrden"].HeaderText = "Fecha";
            dtgvOrdenes.Columns["totalOrden"].HeaderText = "Total";
            dtgvOrdenes.Columns["tipoOrden"].HeaderText = "Tipo";
            dtgvOrdenes.Columns["codEmpleado"].HeaderText = "N° Empleado";
            dtgvOrdenes.Columns["estadoOrden"].HeaderText = "Estado";
            dtgvOrdenes.Columns["codMesa"].HeaderText = "N° Mesa";
            dtgvOrdenes.Columns["codCliente"].HeaderText = "N° Cliente";
            dtgvOrdenes.Columns["Cliente"].Visible = false;
            dtgvOrdenes.Columns["DetallePedido"].Visible = false;
            dtgvOrdenes.Columns["Empleado"].Visible = false;
            dtgvOrdenes.Columns["Mesa"].Visible = false;
        }

        private void GuardarPDF(byte[] content, string fileName)
        {
            int counter = 1;
            string newFileName = fileName;

            // Verifica si el archivo ya existe y agrega un número incremental al nombre
            while (File.Exists(newFileName))
            {
                newFileName = $"{Path.GetFileNameWithoutExtension(fileName)} ({counter++}){Path.GetExtension(fileName)}";
            }

            using (var fileStream = new FileStream(newFileName, FileMode.Create, FileAccess.Write))
            {
                fileStream.Write(content, 0, content.Length);
            }

            MessageBox.Show($"PDF generado exitosamente. Se guardó como {newFileName}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int GetVisibleColumnCount()
        {
            int count = 0;
            foreach (DataGridViewColumn column in dtgvOrdenes.Columns)
            {
                if (IsColumnVisible(column))
                {
                    count++;
                }
            }
            return count;
        }

        private bool IsColumnVisible(DataGridViewColumn column)
        {
            // Excluye las columnas Cliente, DetallePedido, Empleado y Mesa
            return column.Visible && column.Name != "Cliente" && column.Name != "DetallePedido" && column.Name != "Empleado" && column.Name != "Mesa";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpInicio.Value;
            DateTime fechaFin = dtpFinal.Value;

            var ventas = Entity.Orden
                .Where(v => v.fechaOrden >= fechaInicio && v.fechaOrden <= fechaFin)
                .ToList();

           // Mostrar busqueda
            dtgvOrdenes.DataSource = ventas;

            double sumVentas = ventas.Sum(v => v.totalOrden);

            lblTotal.Text = $"Total: {sumVentas:C}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.MostrarOrdenes();

            lblTotal.Text = "Total: 0.0";
        }

     
    }
}
