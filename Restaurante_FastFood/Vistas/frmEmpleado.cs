using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using Clases.ModeloLogico;

namespace Restaurante_FastFood.Vistas
{
    public partial class frmEmpleado : Form
    {
        private DataBase_RestaurantEntities Entity = new DataBase_RestaurantEntities();

        // Objetos del modelo Empleado y Usuario
        private Usuario objUsuario = new Usuario();
        private Empleado objEmpleado = new Empleado();

        // Objeto de la clase repositorio REmpleado y RUsuario
        REmpleado objREmpleado = new REmpleado();
        RUsuario objRUsuario = new RUsuario();

        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            MostrarEmpleados();
            dtgvDatosEmpleado.ReadOnly = true;
        }

        // METODOS PRINCIPALES
        private void AgregarEmpleado()
        {
            // Objeto del modelo Empleado
            int codObtenido = objUsuario.idUsuario;
            objEmpleado.codUsuario = codObtenido;
            objEmpleado.nombreEmpleado = txtPNombre.Text + " " + txtSNombre.Text;
            objEmpleado.apellidoEmpleado = txtPApellido.Text + " " + txtSApellido.Text;
            objEmpleado.telefonoEmpleado = txtTelefono.Text;
            objEmpleado.sueldoEmpleado = double.Parse(txtSueldoNeto.Text);

            int respuesta = objREmpleado.Create(objEmpleado);

            respuesta.ToString();
            if (respuesta != -1)
            {
                MessageBox.Show("Empleado y Usuario ingresado Exitosamente", "Registro de empleado/usuario",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarEmpleados();
            }
            else
            {
                MessageBox.Show("ERROR: Empleado no ingresador", "Registro de empleado",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LimpiarCampos();

        }

        private void AgregarUsuario()
        {
            // Objeto del model Usuario
            objUsuario.nombreUsuario = txtUsuario.Text;
            string contrasenia = MD5Hash(txtContrasenia.Text);
            objUsuario.passwordUsuario = contrasenia;
            objUsuario.codRol = cmbCargo.SelectedIndex + 1;

            int respuesta = objRUsuario.Create(objUsuario);

            respuesta.ToString();
            if (respuesta != -1)
            {
                // No hago nada
            }
            else
            {
                MessageBox.Show("Usuario no ingresador", "Registro de usuario",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarEmpleados()
        {
            var query = from empleado in Entity.Empleado
                        join usuario in Entity.Usuario on empleado.codUsuario equals usuario.idUsuario
                        join rol in Entity.Rol on usuario.codRol equals rol.idRol
                        select new
                        {
                            ID = empleado.idEmpleado,
                            Nombre = empleado.nombreEmpleado,
                            Apellido = empleado.apellidoEmpleado,
                            Telefono = empleado.telefonoEmpleado,
                            Sueldo = empleado.sueldoEmpleado,
                            Usuario = usuario.nombreUsuario,
                            Contraseña = usuario.passwordUsuario,
                            Cargo = rol.nombreRol,
                            IdUsuario = usuario.idUsuario
                        };

            dtgvDatosEmpleado.DataSource = query.ToList();
        }

        private void EliminarRegistroUsuario()
        {
            RUsuario nuevoRUsuario = new RUsuario();
            int idUsuario = int.Parse(txtIdUsuario.Text);
            int respuesta = nuevoRUsuario.Delete(idUsuario);
            if (respuesta != -1)
            {
                // No hacer nada
            }
            else
            {
                MessageBox.Show("ERROR: No se pudo eliminar el usuario", "Eliminar usuario",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarRegistroEmpleado()
        {
                REmpleado nuevoREmpleado = new REmpleado();
                int idEmpleado = int.Parse(txtIdEmpleado.Text);
                int respuesta = nuevoREmpleado.Delete(idEmpleado);
                if (respuesta != -1)
                {
                    MessageBox.Show("Empleado y usuario eliminado exitosamente", "Eliminar empleado/usuario",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarEmpleados();
                }
                else
                {
                    MessageBox.Show("ERROR: No se pudo eliminar el empleado", "Eliminar empleado",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void ActualizarRegistroUsuario()
        {
            if (!string.IsNullOrEmpty(txtIdUsuario.Text))
            {
                // Para encriptar la nueva contraseña
                string contrasenia = MD5Hash(txtContrasenia.Text);

                Usuario nuevoUsuario = new Usuario();
                nuevoUsuario.idUsuario = int.Parse(txtIdUsuario.Text);
                nuevoUsuario.codRol = cmbCargo.SelectedIndex + 1;
                nuevoUsuario.nombreUsuario = txtUsuario.Text;
                nuevoUsuario.passwordUsuario = contrasenia;
                

                int respuesta = objRUsuario.Update(nuevoUsuario);

                if (respuesta != -1)
                {
                    // No hago nada
                }
                else
                {
                    MessageBox.Show("ERROR: No se pudo actualizar el usuario del empleado", "Actualizar usuario",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para actualizar.", "Actualizar usuario",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ActualizarRegistroEmpleado()
        {
            string nomUsuario = txtUsuario.Text;
            int codUsuario = objRUsuario.ObtenerIdUsuario(nomUsuario);

            Empleado nuevoEmpleado = new Empleado();

            nuevoEmpleado.codUsuario = codUsuario;
            nuevoEmpleado.idEmpleado = int.Parse(txtIdEmpleado.Text);
            nuevoEmpleado.nombreEmpleado = txtPNombre.Text + " " + txtSNombre.Text;
            nuevoEmpleado.apellidoEmpleado = txtPApellido.Text + " " + txtSApellido.Text;
            nuevoEmpleado.telefonoEmpleado = txtTelefono.Text;
            nuevoEmpleado.sueldoEmpleado = double.Parse(txtSueldoNeto.Text);
            

            int respuesta = objREmpleado.Update(nuevoEmpleado);

            if (respuesta != -1)
            {
                MessageBox.Show("Empleado y usuario actualizado exitosamente", "Actualización de empleado/usuario",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarEmpleados();
            }
            else
            {
                MessageBox.Show("ERROR: No se pudo actualizar el empleado", "Actualización de empleado",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // METODOS SECUNDARIOS
        private void GenerarUsuario()
        {
            // Genera un Usuario y contraseña estandar pero unica para cada empleado.
            string usuario, password, minUsuario, minPassword;

            usuario = txtPNombre.Text + "." + txtPApellido.Text + "@carlsburgers.com";
            minUsuario = usuario.ToLower();
            password = txtPNombre.Text + "001";
            minPassword = password.ToLower();

            txtUsuario.Text = minUsuario;
            txtContrasenia.Text = minPassword;
        }

        private void CalcularSalario()
        {
            string salario = txtSueldo.Text;
            if (!string.IsNullOrWhiteSpace(salario))
            {
                // Calcular el sueldo tras deducciones de ley
                double deduccionRenta, deduccionISSS, deduccionAFP, totalDeducciones, sueldoBase, sueldoNeto;

                deduccionRenta = double.Parse(txtSueldo.Text) * 0.10;
                deduccionISSS = double.Parse(txtSueldo.Text) * 0.03;
                deduccionAFP = double.Parse(txtSueldo.Text) * 0.0725;

                totalDeducciones = deduccionRenta + deduccionISSS + deduccionAFP;
                sueldoBase = double.Parse(txtSueldo.Text);
                sueldoNeto = sueldoBase - totalDeducciones;
                txtSueldoNeto.Text = sueldoNeto.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese el salario para calcular salario con deducciones", "Calcular salario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }

        private void LimpiarCampos()
        {
            txtIdEmpleado.Clear();
            txtPNombre.Clear();
            txtSNombre.Clear();
            txtPApellido.Clear();
            txtSApellido.Clear();
            txtTelefono.Clear();
            txtIdUsuario.Clear();
            cmbCargo.SelectedIndex = -1;
            txtSueldo.Clear();
            txtUsuario.Clear();
            txtContrasenia.Clear();
            txtSueldoNeto.Clear();
        }

        // EVENTOS
        private void btnRegistrarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreEmpleado = txtPNombre.Text;
                string apellidoEmpleado = txtPApellido.Text;
                string telefonoEmpleado = txtTelefono.Text;
                string sueldoEmpleado = txtSueldoNeto.Text;
                string usuario = txtUsuario.Text;
                string password = txtContrasenia.Text;

                if (string.IsNullOrWhiteSpace(nombreEmpleado) || string.IsNullOrWhiteSpace(apellidoEmpleado) || string.IsNullOrWhiteSpace(telefonoEmpleado) || string.IsNullOrWhiteSpace(sueldoEmpleado)
                    || string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios antes de registrar.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    this.AgregarUsuario();
                    this.AgregarEmpleado();
                }
            }
            catch
            {
                MessageBox.Show("ERROR: Ocurrio un error al intentar registrar empleado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtIdEmpleado.Text))
                {
                    DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        this.EliminarRegistroEmpleado();
                        this.EliminarRegistroUsuario();
                    }

                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un empleado o usuario para eliminar.", "Eliminar empleado/usuario",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("ERROR: Ocurrio un error al intentar eliminar empleado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dtgvDatosEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvDatosEmpleado.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgvDatosEmpleado.SelectedRows[0];
                this.txtIdEmpleado.Text = filaSeleccionada.Cells["ID"].Value.ToString();
                this.txtPNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                this.txtPApellido.Text = filaSeleccionada.Cells["Apellido"].Value.ToString();
                this.txtTelefono.Text = filaSeleccionada.Cells["Telefono"].Value.ToString();
                this.cmbCargo.SelectedText = filaSeleccionada.Cells["Cargo"].Value.ToString();
                this.txtSueldoNeto.Text = filaSeleccionada.Cells["Sueldo"].Value.ToString();
                this.txtUsuario.Text = filaSeleccionada.Cells["Usuario"].Value.ToString();
                this.txtContrasenia.Text = filaSeleccionada.Cells["Contraseña"].Value.ToString();
                this.txtIdUsuario.Text = filaSeleccionada.Cells["IdUsuario"].Value.ToString();
            }
        }

        private void btnGenerarUsuario_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPNombre.Text) || !string.IsNullOrEmpty(txtPApellido.Text))
            {
                GenerarUsuario();
            }
            else
            {
                MessageBox.Show("Ingrese el primer nombre y primer apellido, para generar el usuario y contraseña", "Generar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnCalcularSueldo_Click(object sender, EventArgs e)
        {
            CalcularSalario();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.ToLower();
            var queryFiltrada = from empleado in Entity.Empleado
                                join usuario in Entity.Usuario on empleado.codUsuario equals usuario.idUsuario
                                join rol in Entity.Rol on usuario.codRol equals rol.idRol
                                where empleado.idEmpleado.ToString().Contains(filtro) || empleado.nombreEmpleado.ToLower().Contains(filtro) || rol.nombreRol.ToLower().Contains(filtro)
                                
                                select new
                                {
                                    ID = empleado.idEmpleado,
                                    Nombre = empleado.nombreEmpleado,
                                    Apellido = empleado.apellidoEmpleado,
                                    Telefono = empleado.telefonoEmpleado,
                                    Sueldo = empleado.sueldoEmpleado,
                                    Usuario = usuario.nombreUsuario,
                                    Contraseña = usuario.passwordUsuario,
                                    Cargo = rol.nombreRol,
                                    IdUsuario = usuario.idUsuario
                                };

            dtgvDatosEmpleado.DataSource = queryFiltrada.ToList();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtIdEmpleado.Text))
                {
                    DialogResult respuesta = MessageBox.Show("¿Está seguro de actualizar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        ActualizarRegistroUsuario();
                        ActualizarRegistroEmpleado();
                        LimpiarCampos();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un empleado o usuario para actualizar.", "Actualizar empleado/usuario",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch
            {
                MessageBox.Show("ERROR: Ocurrio un error al intentar registrar empleado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
