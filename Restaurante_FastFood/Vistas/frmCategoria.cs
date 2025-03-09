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
    public partial class frmCategoria : Form
    {
        // Objeto de la clase RCategoria
        private RCategoria objRCategoria = new RCategoria();
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            MostrarCategoria();
            dtgvCategoria.ReadOnly = true;
        }

        
        //METODOS PRINCIPALES
        private void MostrarCategoria()
        {
            // Obtener la tabla Categoria para mostrar en el dataGridView
            List<Categoria> categoria = objRCategoria.GetAll();

            dtgvCategoria.DataSource = categoria;

            dtgvCategoria.Columns["idCategoria"].HeaderText = "ID";
            dtgvCategoria.Columns["nombreCategoria"].HeaderText = "Nombre";
        }

        private void AgregarCategoria()
        {
            Categoria objCategoria = new Categoria();
            objCategoria.nombreCategoria = txtNombreCategoria.Text;

            int respuesta = objRCategoria.Create(objCategoria);

            respuesta.ToString();
            if (respuesta != -1)
            {
                MessageBox.Show("Categoria ingresada Exitosamente", "Registro de categoria",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarCategoria();
            }
            else
            {
                MessageBox.Show("ERROR: Cataegoria no ingresada", "Registro de categoria",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Limpiar los textBox
            LimpiarCampos();
        }
        private void EliminarCategoria()
        {
            int respuesta = objRCategoria.Delete(int.Parse(this.txtIdCategoria.Text));
            if (respuesta != -1)
            {
                MessageBox.Show("Categoria eliminada exitosamente", "Eliminar categoria",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarCategoria();
            }
            else
            {
                MessageBox.Show("ERROR: No se pudo eliminar la categoria", "Eliminar categoria",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //METODOS SECUNDARIOS
        private void LimpiarCampos()
        {
            txtIdCategoria.Clear();
            txtNombreCategoria.Clear();
        }

        // EVENTOS
        private void btnAgregarCat_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreCategoria.Text;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios antes de registrar.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                AgregarCategoria();
            }
        }

        private void btnEliminarCat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdCategoria.Text))
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    this.EliminarCategoria();
                }

                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una categoria para eliminar.", "Eliminar categoria",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvCategoria.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgvCategoria.SelectedRows[0];
                this.txtIdCategoria.Text = filaSeleccionada.Cells["idCategoria"].Value.ToString();
                this.txtNombreCategoria.Text = filaSeleccionada.Cells["nombreCategoria"].Value.ToString();
            }
        }

        private void btnSalirCat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
