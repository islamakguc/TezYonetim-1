﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

public partial class TezDBEntities : DbContext
{
    public TezDBEntities()
        : base("name=TezDBEntities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<Admin> Admin { get; set; }
    public virtual DbSet<Duyuru> Duyuru { get; set; }
    public virtual DbSet<Duyuru_Admin> Duyuru_Admin { get; set; }
    public virtual DbSet<Hoca> Hoca { get; set; }
    public virtual DbSet<Mesaj> Mesaj { get; set; }
    public virtual DbSet<Ogrenci> Ogrenci { get; set; }
    public virtual DbSet<Rapor> Rapor { get; set; }
    public virtual DbSet<Rapor_Tarih> Rapor_Tarih { get; set; }
    public virtual DbSet<Sistem> Sistem { get; set; }
    public virtual DbSet<Tarih> Tarih { get; set; }
    public virtual DbSet<Tez> Tez { get; set; }
    public virtual DbSet<Tez_Kitap> Tez_Kitap { get; set; }
}
