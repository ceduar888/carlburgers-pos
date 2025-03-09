using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.ModeloLogico
{
    public class RCategoria : IRepositorio<Categoria>
    {
        // Instancia del Entity framework
        private DataBase_RestaurantEntities Entity = new DataBase_RestaurantEntities();

        public int Create(Categoria modelo)
        {
            try
            {
                Entity.Categoria.Add(modelo);
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
                var registro = Entity.Categoria.Find(recordID);
                Entity.Categoria.Remove(registro);
                return Entity.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }

        }

        public List<Categoria> GetAll()
        {
            return Entity.Categoria.ToList();
        }

        public int Update(Categoria modelo)
        {
            throw new NotImplementedException();
        }
    }
}
