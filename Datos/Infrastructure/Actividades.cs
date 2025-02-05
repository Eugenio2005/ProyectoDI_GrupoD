//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos.Infrastructure
{
    using System;
    using System.Collections.Generic;
    
    public partial class Actividades
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Actividades()
        {
            this.Usuarios_Actividades = new HashSet<Usuarios_Actividades>();
            this.Valoraciones = new HashSet<Valoraciones>();
        }
    
        public int id_actividad { get; set; }
        public string nombre_actividad { get; set; }
        public string descripcion { get; set; }
        public string email_monitor { get; set; }
        public Nullable<double> valoracion_media { get; set; }
        public Nullable<int> numUsuariosApuntados { get; set; }
        public Nullable<double> precio_actividad { get; set; }
    
        public virtual Monitores Monitores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuarios_Actividades> Usuarios_Actividades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Valoraciones> Valoraciones { get; set; }
    }
}
