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
    
    public partial class VEHICULO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VEHICULO()
        {
            this.RENTA = new HashSet<RENTA>();
        }
    
        public int ID { get; set; }
        public string DESCRIPCION { get; set; }
        public string NUMERO_CHASIS { get; set; }
        public string NUMERO_MOTOR { get; set; }
        public string NUMERO_PLACA { get; set; }
        public Nullable<int> ID_TIPO_VEHICULO { get; set; }
        public Nullable<int> ID_MODELO_VEHICULO { get; set; }
        public Nullable<int> ID_TIPO_COMBUSTIBLE { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
        public Nullable<bool> ESTADO { get; set; }
    
        public virtual COMBUSTIBLE_VEHICULO COMBUSTIBLE_VEHICULO { get; set; }
        public virtual MODELO_VEHICULO MODELO_VEHICULO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RENTA> RENTA { get; set; }
        public virtual TIPO_VEHICULO TIPO_VEHICULO { get; set; }
    }
}
