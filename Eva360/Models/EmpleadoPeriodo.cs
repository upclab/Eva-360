//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eva360.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmpleadoPeriodo
    {
        public int EmpleadoPeriodoId { get; set; }
        public int EmpleadoId { get; set; }
        public Nullable<int> SupervisorId { get; set; }
        public int PeriodoId { get; set; }
        public int UsuarioCreacionId { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public Nullable<int> UsuarioModificacionId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
    
        public virtual Empleado Empleado { get; set; }
        public virtual Periodo Periodo { get; set; }
        public virtual Supervisor Supervisor { get; set; }
    }
}