﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace gestion_cabinet_notarial.context
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class gestion_cabinet_notarialEntities : DbContext
    {
        public gestion_cabinet_notarialEntities()
            : base("name=gestion_cabinet_notarialEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<banque> banques { get; set; }
        public virtual DbSet<Banque_pret> Banque_pret { get; set; }
        public virtual DbSet<CDG> CDGs { get; set; }
        public virtual DbSet<client> clients { get; set; }
        public virtual DbSet<ClientNormale> ClientNormales { get; set; }
        public virtual DbSet<ClientProfessionnel> ClientProfessionnels { get; set; }
        public virtual DbSet<contrat> contrats { get; set; }
        public virtual DbSet<credit> credits { get; set; }
        public virtual DbSet<devi> devis { get; set; }
        public virtual DbSet<dossier> dossiers { get; set; }
        public virtual DbSet<facture> factures { get; set; }
        public virtual DbSet<fichiers_client> fichiers_client { get; set; }
        public virtual DbSet<fichiers_contrat> fichiers_contrat { get; set; }
        public virtual DbSet<fichiers_dossier> fichiers_dossier { get; set; }
        public virtual DbSet<fonction> fonctions { get; set; }
        public virtual DbSet<log> logs { get; set; }
        public virtual DbSet<note> notes { get; set; }
        public virtual DbSet<parte> partes { get; set; }
        public virtual DbSet<payement> payements { get; set; }
        public virtual DbSet<recu> recus { get; set; }
        public virtual DbSet<Rendez_vous> Rendez_vous { get; set; }
        public virtual DbSet<Signature> Signatures { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<utilisateur> utilisateurs { get; set; }
        public virtual DbSet<information_cabinet> information_cabinet { get; set; }
    }
}