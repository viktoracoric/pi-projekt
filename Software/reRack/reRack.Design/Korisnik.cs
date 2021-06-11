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
    
    public partial class Korisnik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Korisnik()
        {
            this.Clanstvo = new HashSet<Clanstvo>();
            this.Recenzija = new HashSet<Recenzija>();
            this.Rezervacija = new HashSet<Rezervacija>();
            this.Teretana = new HashSet<Teretana>();
        }
    
        public int id_korisnik { get; set; }
        public int uloga_id { get; set; }
        public int grad_id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string korisnicko_ime { get; set; }
        public string lozinka { get; set; }
        public string mail { get; set; }
        public string broj_telefona { get; set; }
        public System.DateTime datum_registracije { get; set; }
        public decimal raspoloziva_sredstva { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clanstvo> Clanstvo { get; set; }
        public virtual Grad Grad { get; set; }
        public virtual Uloga Uloga { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recenzija> Recenzija { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rezervacija> Rezervacija { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Teretana> Teretana { get; set; }

        public override string ToString()
        {
            return korisnicko_ime;
        }
    }
}
