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
    
    public partial class INSPECCION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSPECCION()
        {
            this.INSPECCION_GOMAS = new HashSet<INSPECCION_GOMAS>();
            this.RENTA = new HashSet<RENTA>();
        }
    
        public int ID { get; set; }
        public Nullable<int> ID_VEHICULO { get; set; }
        public Nullable<int> ID_CLIENTE { get; set; }
        public Nullable<int> ID_EMPLEADO { get; set; }
        public Nullable<bool> TIENE_RAYADURAS { get; set; }
        public Nullable<int> ID_CANTIDAD_COMBUSTIBLE { get; set; }
        public Nullable<bool> TIENE_GOMA { get; set; }
        public Nullable<bool> TIENE_GATO { get; set; }
        public Nullable<bool> TIENE_ROTURA_CRISTAL { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
        public Nullable<int> ID_ESTADO_INSPECCION { get; set; }
        public string CODIGO { get; set; }
        public Nullable<bool> GOMA_TRASERA_DERECHA { get; set; }
        public Nullable<bool> GOMA_TRASERA_IZQUIERDA { get; set; }
        public Nullable<bool> GOMA_DELANTERA_DERECHA { get; set; }
        public Nullable<bool> GOMA_DELANTERA_IZQUIERDA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSPECCION_GOMAS> INSPECCION_GOMAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RENTA> RENTA { get; set; }
    }
}
