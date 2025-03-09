using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.ModeloLogico
{
    public class REmpleado : IRepositorio<Empleado>
    {
        // Instancia del EntityFramework
        private DataBase_RestaurantEntities Entity = new DataBase_RestaurantEntities();

        public int Create(Empleado modelo)
        {
            try
            {
                modelo.Usuario = Entity.Usuario.Find(modelo.codUsuario);
                Entity.Empleado.Add(modelo);
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
                var registro = Entity.Empleado.Find(recordID);
                Entity.Empleado.Remove(registro);
                return Entity.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public List<Empleado> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Update(Empleado modelo)
        {
            try
            {
                var empleadoActual = Entity.Empleado.Find(modelo.idEmpleado);

                if(empleadoActual != null)
                {
                    // Actualizar los datos del cliente actual con los del cliente nuevo
                    empleadoActual.nombreEmpleado = modelo.nombreEmpleado;
                    empleadoActual.apellidoEmpleado = modelo.apellidoEmpleado;
                    empleadoActual.telefonoEmpleado = modelo.telefonoEmpleado;
                    empleadoActual.sueldoEmpleado = modelo.sueldoEmpleado;

                    return Entity.SaveChanges();
                }
                else
                {
                    return -1;
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }
    }
}
