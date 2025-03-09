using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.ModeloLogico
{
    public class RDetallePedido : IRepositorio<DetallePedido>
    {
        DataBase_RestaurantEntities Entity = new DataBase_RestaurantEntities();

        public int Create(DetallePedido modelo)
        {
            try
            {
                Entity.DetallePedido.Add(modelo);
                return Entity.SaveChanges();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public int Create(List<DetallePedido> modelos)
        {
            try
            {
                Entity.DetallePedido.AddRange(modelos);
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

        public List<DetallePedido> GetAll()
        {
            return Entity.DetallePedido.ToList();
        }

        public int Update(DetallePedido modelo)
        {
            throw new NotImplementedException();
        }
    }
}
