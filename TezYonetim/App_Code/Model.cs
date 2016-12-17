﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class Admin
{
    public int Id { get; set; }
    public string KullanıcıAdi { get; set; }
    public string Sifre { get; set; }
    public string Mail { get; set; }
    public Nullable<int> Derece { get; set; }
}

public partial class Hoca
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Hoca()
    {
        this.Ogrenci = new HashSet<Ogrenci>();
        this.Rapor = new HashSet<Rapor>();
        this.Tez = new HashSet<Tez>();
    }

    public int Id { get; set; }
    public string Ad { get; set; }
    public string Sifre { get; set; }
    public string Mail { get; set; }
    public string Ders { get; set; }
    public Nullable<int> Derece { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Ogrenci> Ogrenci { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Rapor> Rapor { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Tez> Tez { get; set; }
}

public partial class Ogrenci
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Ogrenci()
    {
        this.Rapor = new HashSet<Rapor>();
        this.Tez1 = new HashSet<Tez>();
    }

    public int Id { get; set; }
    public Nullable<int> Hoca_ID { get; set; }
    public string Ad { get; set; }
    public string No { get; set; }
    public string Sifre { get; set; }
    public string Mail { get; set; }
    public string Bolum { get; set; }
    public Nullable<int> Derece { get; set; }
    public string Tez { get; set; }
    public Nullable<int> Tez_Durum { get; set; }

    public virtual Hoca Hoca { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Rapor> Rapor { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Tez> Tez1 { get; set; }
}

public partial class Rapor
{
    public int Id { get; set; }
    public Nullable<int> Hoca_Id { get; set; }
    public Nullable<int> Ogrenci_Id { get; set; }
    public string Ad { get; set; }
    public string Tarih { get; set; }
    public string Aciklama { get; set; }

    public virtual Hoca Hoca { get; set; }
    public virtual Ogrenci Ogrenci { get; set; }
}

public partial class Tez
{
    public int Id { get; set; }
    public Nullable<int> Hoca_ID { get; set; }
    public Nullable<int> Og_ID { get; set; }
    public string Konu { get; set; }
    public string Aciklama { get; set; }
    public Nullable<int> Durum { get; set; }
    public Nullable<int> Onay { get; set; }

    public virtual Hoca Hoca { get; set; }
    public virtual Ogrenci Ogrenci { get; set; }
}
