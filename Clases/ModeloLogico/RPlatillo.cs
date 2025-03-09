using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.ModeloLogico
{
    public class RPlatillo : IRepositorio<Platillo>
    {
        DataBase_RestaurantEntities Entity = new DataBase_RestaurantEntities();
        public int Create(Platillo modelo)
        {
            try
            {
                Entity.Platillo.Add(modelo);
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
                var registro = Entity.Platillo.Find(recordID);
                Entity.Platillo.Remove(registro);
                return Entity.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public List<Platillo> GetAll()
        {
            return Entity.Platillo.ToList();
        }

        public int Update(Platillo modelo)
        {
            try
            {
                var platilloActual = Entity.Platillo.Find(modelo.idPlatillo);
                if (platilloActual != null)
                {
                    // Actualiza los valores existentes, por los nuevos que se han enviado
                    platilloActual.nombrePlatillo = modelo.nombrePlatillo;
                    platilloActual.descPlatillo = modelo.descPlatillo;
                    platilloActual.precioPlatillo = modelo.precioPlatillo;
                    platilloActual.codCategoria = modelo.codCategoria;

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

        // METODOS COMPLEMENTARIOS
        public string ObtenerNombrePlatillo(int idPlatillo)
        {
            var nombrePlatillo = Entity.Platillo.FirstOrDefault(p => p.idPlatillo == idPlatillo);
            if (nombrePlatillo != null)
            {
                 return $"{nombrePlatillo.nombrePlatillo}";   
            }
            return null;
        }
    }
}
