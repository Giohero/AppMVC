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
    
    public partial class Accesorios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Accesorios()
        {
            this.Inventario = new HashSet<Inventario>();
        }
    
        public int ID_Accesorio { get; set; }
        public string Nombre_Accesorio { get; set; }
        public Nullable<double> Precio_Accesorio { get; set; }
        public string Descripcion_Accesorio { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventario> Inventario { get; set; }
    }
}