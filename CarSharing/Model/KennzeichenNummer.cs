//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarSharing.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class KennzeichenNummer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KennzeichenNummer()
        {
            this.Auto = new HashSet<Auto>();
        }
    
        public int KennzeichenNummerId { get; set; }
        public string KennzeichenNummer1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Auto> Auto { get; set; }
    }
}