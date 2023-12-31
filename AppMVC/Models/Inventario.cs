//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inventario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inventario()
        {
            this.Detalle_Ventas = new HashSet<Detalle_Ventas>();
        }
    
        public int ID_Inventario { get; set; }
        public Nullable<int> ID_Juego { get; set; }
        public Nullable<int> ID_Consola { get; set; }
        public Nullable<int> ID_Extra { get; set; }
        public Nullable<int> ID_Accesorio { get; set; }
        public Nullable<int> ID_Coleccionable { get; set; }
        public Nullable<int> Cantidad_Disponible { get; set; }
        public Nullable<decimal> Precio_Venta { get; set; }
    
        public virtual Accesorios Accesorios { get; set; }
        public virtual Coleccionables Coleccionables { get; set; }
        public virtual Consolas Consolas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_Ventas> Detalle_Ventas { get; set; }
        public virtual Extras Extras { get; set; }
        public virtual Juegos Juegos { get; set; }
    }
}
