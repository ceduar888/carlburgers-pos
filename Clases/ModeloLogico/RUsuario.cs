using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Clases.ModeloLogico
{
    public class RUsuario : IRepositorio<Usuario>
    {
        //Objeto del EntityFramework
        private DataBase_RestaurantEntities Entity = new DataBase_RestaurantEntities();
        public int Create(Usuario modelo)
        {
            try
            {
                modelo.Rol = Entity.Rol.Find(modelo.codRol);
                Entity.Usuario.Add(modelo);
                return Entity.SaveChanges();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public int Delete(int recordID)
        {
            try
            {
                var registro = Entity.Usuario.Find(recordID);
                Entity.Usuario.Remove(registro);
                return Entity.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public List<Usuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Update(Usuario modelo)
        {
            try
            {
                var usuarioActual = Entity.Usuario.Find(modelo.idUsuario);

                if (usuarioActual != null)
                {
                    usuarioActual.nombreUsuario = modelo.nombreUsuario;
                    usuarioActual.passwordUsuario = modelo.passwordUsuario;
                    usuarioActual.codRol = modelo.codRol;

                    return Entity.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Error");
                    return -1;
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        // METODOS ADICIONALES
        public bool login(Usuario modelo)
        {
            string contrasenha = modelo.passwordUsuario;
            string passwordHash = this.MD5Hash(contrasenha);
            modelo.passwordUsuario = passwordHash;
            string nombreUsuario = modelo.nombreUsuario;
            var usuarioEncontrado = Entity.Usuario.FirstOrDefault(u => u.nombreUsuario == nombreUsuario
            && u.passwordUsuario == passwordHash);
            if (usuarioEncontrado != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Metodo para obtener el valor entero del rol del usuario
        public int RolDelUsuario(string nombreUsuario)
        {
            var usuario = Entity.Usuario.FirstOrDefault(u => u.nombreUsuario == nombreUsuario);
            if (usuario != null)
            {
                return (int)usuario.codRol;
            }
            return -1;
        }

        // Metodo para obtener el nombre del empleado que ha ingresado y mostrarlo en el frmHome
        public string NombreUsuario(string nombreUsuario)
        {
            var usuario = Entity.Usuario.FirstOrDefault(u => u.nombreUsuario == nombreUsuario);
            if (usuario != null)
            {
                var empleado = Entity.Empleado.FirstOrDefault(e => e.codUsuario == usuario.idUsuario);
                if (empleado != null)
                {
                    return $"{empleado.nombreEmpleado} {empleado.apellidoEmpleado}";
                }
            }
            return null;
        }

        // Metodo para obtener el id de usuario
        public int ObtenerIdUsuario(string nomUsuario)
        {
            var usuario = Entity.Usuario.FirstOrDefault(u => u.nombreUsuario == nomUsuario);
            if (usuario != null)
            {
                return usuario.idUsuario;
            }
            else
            {
                return -1;
            }
        }

        public int IdEmpleado(string nombreUsuario)
        {
            var usuario = Entity.Usuario.FirstOrDefault(u => u.nombreUsuario == nombreUsuario);
            if (usuario != null)
            {
                var empleado = Entity.Empleado.FirstOrDefault(e => e.codUsuario == usuario.idUsuario);
                if (empleado != null)
                {
                    return empleado.idEmpleado;
                }
            }
            return -1;
        }

            // Metodo para encriptar la contraseña con MD5
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
    }
}
