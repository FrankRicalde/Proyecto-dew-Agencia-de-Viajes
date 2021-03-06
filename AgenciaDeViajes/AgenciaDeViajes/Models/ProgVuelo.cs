//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AgenciaDeViajes.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProgVuelo
    {
        public ProgVuelo()
        {
            this.GestionPaquete = new HashSet<GestionPaquete>();
        }
    
        public string idProgVuelo { get; set; }
        public string idProveedor { get; set; }
        public string idAvion { get; set; }
        public string puntoPartida { get; set; }
        public string puntoLLegada { get; set; }
        public string escala { get; set; }
        public Nullable<System.DateTime> fecha_salida { get; set; }
        public Nullable<System.DateTime> fecha_llegada { get; set; }
    
        public virtual Aeropuerto Aeropuerto { get; set; }
        public virtual Aeropuerto Aeropuerto1 { get; set; }
        public virtual Aeropuerto Aeropuerto2 { get; set; }
        public virtual Avion Avion { get; set; }
        public virtual ICollection<GestionPaquete> GestionPaquete { get; set; }
        public virtual Proveedor Proveedor { get; set; }
    }
}
