//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Clases
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetallePedido
    {
        public int idDetallePedido { get; set; }
        public int cantidad { get; set; }
        public double subTotal { get; set; }
        public Nullable<int> codMesa { get; set; }
        public Nullable<int> codOrden { get; set; }
        public Nullable<int> codPlatillo { get; set; }
    
        public virtual Mesa Mesa { get; set; }
        public virtual Orden Orden { get; set; }
        public virtual Platillo Platillo { get; set; }
    }
}
