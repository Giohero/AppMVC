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
    
    public partial class Servidores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Servidores()
        {
            this.PermisosServidores = new HashSet<PermisosServidores>();
        }
    
        public int ID_Servidor { get; set; }
        public string Nombre { get; set; }
        public string IP { get; set; }
        public string SistemaOperativo { get; set; }
        public string Aplicaciones { get; set; }
        public string Descripcion { get; set; }
        public string Comentarios { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PermisosServidores> PermisosServidores { get; set; }
    }
}