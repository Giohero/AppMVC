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
    
    public partial class Detalle_Ventas
    {
        public int ID_Venta { get; set; }
        public int ID_Inventario { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<decimal> Precio_Venta { get; set; }
    
        public virtual Inventario Inventario { get; set; }
        public virtual Ventas Ventas { get; set; }
    }
}
