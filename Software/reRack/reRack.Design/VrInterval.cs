//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace reRack.Design
{
    using System;
    using System.Collections.Generic;
    
    public partial class VrInterval
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VrInterval()
        {
            this.Rezervacija = new HashSet<Rezervacija>();
        }
    
        public int id_interval { get; set; }
        public System.TimeSpan vrijeme_pocetak { get; set; }
        public System.TimeSpan vrijeme_kraj { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rezervacija> Rezervacija { get; set; }

        public override string ToString()
        {
            return vrijeme_pocetak + "-" + vrijeme_kraj;
        }
    }
}
