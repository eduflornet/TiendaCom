//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Configurador.Repositorio.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Componente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Componente()
        {
            this.Configuracion = new HashSet<Configuracion>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal Iva { get; set; }
        public int idCategoria { get; set; }
        public int idFabricante { get; set; }
        public byte[] ImageData { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        public virtual Fabricante Fabricante { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Configuracion> Configuracion { get; set; }
    }
}
