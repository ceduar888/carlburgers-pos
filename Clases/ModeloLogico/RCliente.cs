using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.ModeloLogico
{
    public class RCliente : IRepositorio<Cliente>
    {
        DataBase_RestaurantEntities Entity = new DataBase_RestaurantEntities();
        public int Create(Cliente modelo)
        {
            try
            {
                Entity.Cliente.Add(modelo);
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
                var registro = Entity.Cliente.Find(recordID);
                Entity.Cliente.Remove(registro);
                return Entity.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public List<Cliente> GetAll()
        {
            return Entity.Cliente.ToList();
        }

        public int Update(Cliente modelo)
        {
            try
            {
                var clienteActual = Entity.Cliente.Find(modelo.idCliente); 

                if (clienteActual != null)
                {
                    // Actualizar los campos del cliente existente con los valores del modelo proporcionado.
                    clienteActual.nombreCliente = modelo.nombreCliente;
                    clienteActual.apellidoCliente = modelo.apellidoCliente;
                    clienteActual.telefonoCliente = modelo.telefonoCliente;
                    clienteActual.direccionCliente = modelo.direccionCliente;
                    clienteActual.duiCliente = modelo.duiCliente;

                    return Entity.SaveChanges();
                }
                else
                {
                    // El cliente no se encontró en la base de datos.
                    return -1;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        // Metodo para obtener el id del cliente recibiendo el nombre del cliente
        // Para asignarle el codigo del cliente a la orden hecha
        public int ObtenerCodCliente(string nombreCliente)
        {
            var cliente = Entity.Cliente.FirstOrDefault(c => c.nombreCliente == nombreCliente);

            if (cliente != null)
            {
                return (int)cliente.idCliente;
            }
            else
            {
                return -1;
            }
        }

        
    }
}
