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
    
    public partial class Platillo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Platillo()
        {
            this.DetallePedido = new HashSet<DetallePedido>();
        }
    
        public int idPlatillo { get; set; }
        public string nombrePlatillo { get; set; }
        public double precioPlatillo { get; set; }
        public string descPlatillo { get; set; }
        public Nullable<int> codCategoria { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallePedido> DetallePedido { get; set; }
    }
}
