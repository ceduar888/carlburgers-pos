using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases.ModeloLogico;

namespace Restaurante_FastFood.Vistas
{
    public partial class frmPlatillo : Form
    {
        RPlatillo objRPlatillo = new RPlatillo();
        Platillo objPlatillo = new Platillo();
        public frmPlatillo()
        {
            InitializeComponent();
        }

        private void frmPlatillo_Load(object sender, EventArgs e)
        {
            this.MostrarDatosPlatillo();
            dtgvDatosPlatillo.ReadOnly = true;
        }

        // METODOS PRINCIPALES
        private void MostrarDatosPlatillo()
        {
            List<Platillo> platillos = objRPlatillo.GetAll();

            dtgvDatosPlatillo.DataSource = platillos;

            dtgvDatosPlatillo.Columns["idPlatillo"].HeaderText = "ID";
            dtgvDatosPlatillo.Columns["nombrePlatillo"].HeaderText = "Nombre";
            dtgvDatosPlatillo.Columns["precioPlatillo"].HeaderText = "Precio";
            dtgvDatosPlatillo.Columns["descPlatillo"].HeaderText = "Descripcion";
            dtgvDatosPlatillo.Columns["codCategoria"].HeaderText = "ID Categoria";

            dtgvDatosPlatillo.Columns["Categoria"].Visible = false;
            dtgvDatosPlatillo.Columns["DetallePedido"].Visible = false;
        }

        private void AgregarPlatillo()
        {

            objPlatillo.nombrePlatillo = txtNombrePlatillo.Text;
            objPlatillo.precioPlatillo = double.Parse(txtPrecioPlatillo.Text);
            objPlatillo.descPlatillo = txtDescripcion.Text;
            objPlatillo.codCategoria = cmbCategoria.SelectedIndex + 1;

            int respuesta = objRPlatillo.Create(objPlatillo);

            if (respuesta != -1)
            {
                MessageBox.Show("Platillo ingresado exitosamente", "Registro de platillo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarDatosPlatillo();
            }
            else
            {
                MessageBox.Show("ERROR: platillo no ingresado", "Registro de platillo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.LimpiarCampos();
            
        }

        private void EliminarPlatillo()
        {
            int respuesta = objRPlatillo.Delete(int.Parse(this.txtIdPlatillo.Text));
            if (respuesta != -1)
            {
                MessageBox.Show("Platillo eliminado exitosamente", "Eliminar platillo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarDatosPlatillo();
            }
            else
            {
                MessageBox.Show("ERROR: No se pudo eliminar el platillo", "Eliminar platillo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarPlatillo()
        {
            Platillo nuevoPlatillo = new Platillo();

            nuevoPlatillo.idPlatillo = int.Parse(txtIdPlatillo.Text);
            nuevoPlatillo.nombrePlatillo = txtNombrePlatillo.Text;
            nuevoPlatillo.precioPlatillo = double.Parse(txtPrecioPlatillo.Text);
            nuevoPlatillo.descPlatillo = txtDescripcion.Text;
            nuevoPlatillo.codCategoria = cmbCategoria.SelectedIndex + 1;
            

            int respuesta = objRPlatillo.Update(nuevoPlatillo);

            if (respuesta != -1)
            {
                MessageBox.Show("Platillo actualizado exitosamente", "Actualizar platillo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.MostrarDatosPlatillo();
            }
            else
            {
                MessageBox.Show("ERROR: platillo no actualizado", "Actualizar platillo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.LimpiarCampos();
        }

        // METODOS SECUNDARIOS
        private void LimpiarCampos()
        {
            txtIdPlatillo.Clear();
            txtNombrePlatillo.Clear();
            txtPrecioPlatillo.Clear();
            txtDescripcion.Clear();
            cmbCategoria.SelectedIndex = -1;
        }


        // EVENTOS
        private void btnRegistrarPlatillo_Click(object sender, EventArgs e)
        {
            string nombre = txtNombrePlatillo.Text;
            string precio = txtPrecioPlatillo.Text;
            string descripcion = txtDescripcion.Text;
            string categoria = cmbCategoria.Text;

            if(string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(precio) || string.IsNullOrWhiteSpace(descripcion) ||
               string.IsNullOrWhiteSpace(categoria))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios antes de registrar.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                this.AgregarPlatillo();
            }
        }

        private void dtgvDatosPlatillo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvDatosPlatillo.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgvDatosPlatillo.SelectedRows[0];
                this.txtIdPlatillo.Text = filaSeleccionada.Cells["idPlatillo"].Value.ToString();
                this.txtNombrePlatillo.Text = filaSeleccionada.Cells["nombrePlatillo"].Value.ToString();
                this.txtPrecioPlatillo.Text = filaSeleccionada.Cells["precioPlatillo"].Value.ToString();
                this.txtDescripcion.Text = filaSeleccionada.Cells["descPlatillo"].Value.ToString();
                this.cmbCategoria.SelectedText = filaSeleccionada.Cells["codCategoria"].Value.ToString();
            }
        }

        private void btnEliminarPlatillo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdPlatillo.Text))
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    this.EliminarPlatillo();
                }

            }
            else
            {
                MessageBox.Show("Por favor, seleccione un platillo para eliminar.", "Eliminar platillo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
            this.LimpiarCampos();
        }

        private void btnActualizarPlatilo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdPlatillo.Text))
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    this.ActualizarPlatillo();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un platillo para actulizar.", "Actualizar platillo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnSalirPlatillo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCategoriasDeProd_Click(object sender, EventArgs e)
        {
            frmCategoria fCategoria = new frmCategoria();
            fCategoria.Show();
        }

        private void txtBuscarPlatillo_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscarPlatillo.Text.ToLower();

            List<Platillo> platillos = objRPlatillo.GetAll();

            List<Platillo> platillosFiltrados = platillos.Where(c => c.nombrePlatillo.ToLower().Contains(filtro) || c.precioPlatillo.ToString().Contains(filtro)).ToList();
            dtgvDatosPlatillo.DataSource = platillosFiltrados;
        }
    }
}
