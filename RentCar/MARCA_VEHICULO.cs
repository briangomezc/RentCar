//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentCar
{
    using System;
    using System.Collections.Generic;
    
    public partial class MARCA_VEHICULO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MARCA_VEHICULO()
        {
            this.MODELO_VEHICULO = new HashSet<MODELO_VEHICULO>();
        }
    
        public int ID { get; set; }
        public string NOMBRE { get; set; }
        public Nullable<bool> ESTADO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MODELO_VEHICULO> MODELO_VEHICULO { get; set; }
    }
}
