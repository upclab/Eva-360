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
    
    public partial class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Codigo { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string Estado { get; set; }
        public string NroDocumento { get; set; }
        public int TipoDocumentoId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public Nullable<int> UsuarioCreacionId { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public Nullable<int> UsuarioModificacionId { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
    
        public virtual Empleado Empleado { get; set; }
        public virtual Proveedor Proveedor { get; set; }
        public virtual Supervisor Supervisor { get; set; }
        public virtual TipoDocumento TipoDocumento { get; set; }
    }
}