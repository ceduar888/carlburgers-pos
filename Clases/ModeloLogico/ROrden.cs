using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.ModeloLogico
{
    public class ROrden : IRepositorio<Orden>
    {
        DataBase_RestaurantEntities Entity = new DataBase_RestaurantEntities();
        public int Create(Orden modelo)
        {
            try
            {
                Entity.Orden.Add(modelo);
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
            throw new NotImplementedException();
        }

        public List<Orden> GetAll()
        {
            return Entity.Orden.ToList();
        }

        public int Update(Orden modelo)
        {
            try
            {
                var ordenActual = Entity.Orden.Find(modelo.idOrden);
                if (ordenActual != null)
                {
                    ordenActual.codCliente = modelo.codCliente;

                    return Entity.SaveChanges();
                }
                else
                {
                    return -1;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public int OrdenPagada(int id)
        {
            try
            {
                var orden = Entity.Orden.FirstOrDefault(o => o.idOrden == id);
                if (orden != null)
                {
                    orden.estadoOrden = "Pagada";

                    return Entity.SaveChanges();
                }
                else
                {
                    return -1;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }
        // Metodo para obtener el id de la orden recibiendo el total de ella.
        // Para asignar el id de la orden a cada producto
        public int ObtenerOrden(double total)
        {
            // Se busca la ultima orden registrada con ese total y devuelve el id de esa orden
            var ultimaOrden = Entity.Orden
          .Where(o => o.totalOrden == total)
          .OrderByDescending(o => o.idOrden)
          .FirstOrDefault();

            if (ultimaOrden != null)
            {
                return ultimaOrden.idOrden;
            }
            else
            {
                return -1; 
            }
        }

        // Metodo para obtener el total de la orden recibiendo el id de la orden
        // Para mostar el total de la cuenta en el formulario Cobrar.
        public double ObtenerTotal(int codOrden)
        {
            var total = Entity.Orden.FirstOrDefault(t => t.idOrden == codOrden);
            if (total != null)
            {
                return total.totalOrden;
            }
            else
            {
                return -1;
            }
        }

        
    }
}
