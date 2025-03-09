using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public interface IRepositorio<Modelo>
    {
        //- Metodo que retorne una lista de todos los registros de tipo Modelo
        List<Modelo> GetAll();

        //- Metodo que cree un nuevo registro en base de datos basado en Modelo
        int Create(Modelo modelo);

        //- Metodo que actualice un registro dentro de base de datos basado en Modelo
        int Update(Modelo modelo);

        //- Metodo que elimina un registro de base de datos de la tabla Modelo con base a un ID
        int Delete(int recordID);

    }
}
