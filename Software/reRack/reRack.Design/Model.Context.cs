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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Clanstvo> Clanstvo { get; set; }
        public virtual DbSet<Grad> Grad { get; set; }
        public virtual DbSet<Korisnik> Korisnik { get; set; }
        public virtual DbSet<Recenzija> Recenzija { get; set; }
        public virtual DbSet<Rezervacija> Rezervacija { get; set; }
        public virtual DbSet<Teretana> Teretana { get; set; }
        public virtual DbSet<Uloga> Uloga { get; set; }
        public virtual DbSet<VrInterval> VrInterval { get; set; }
        public virtual DbSet<Zahtjev> Zahtjev { get; set; }
    }
}
