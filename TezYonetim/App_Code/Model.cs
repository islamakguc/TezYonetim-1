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

public partial class Duyuru
{
    public int Id { get; set; }
    public Nullable<int> Hoca_Id { get; set; }
    public string Duyuru_Baslik { get; set; }
    public string Duyuru_Text { get; set; }
    public Nullable<System.DateTime> Duyuru_Tarih { get; set; }

    public virtual Hoca Hoca { get; set; }
}

public partial class Duyuru_Admin
{
    public int Id { get; set; }
    public string Duyuru_Baslik { get; set; }
    public string Duyuru_Text { get; set; }
    public Nullable<System.DateTime> Duyuru_Tarih { get; set; }
}

public partial class Hoca
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Hoca()
    {
        this.Duyuru = new HashSet<Duyuru>();
        this.Ogrenci = new HashSet<Ogrenci>();
        this.Rapor = new HashSet<Rapor>();
        this.Rapor_Tarih = new HashSet<Rapor_Tarih>();
        this.Tez = new HashSet<Tez>();
    }

    public int Id { get; set; }
    public string Ad { get; set; }
    public string Sifre { get; set; }
    public string Mail { get; set; }
    public string Ders { get; set; }
    public Nullable<int> Derece { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Duyuru> Duyuru { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Ogrenci> Ogrenci { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Rapor> Rapor { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Rapor_Tarih> Rapor_Tarih { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Tez> Tez { get; set; }
}

public partial class Mesaj
{
    public int id { get; set; }
    public Nullable<int> Gid { get; set; }
    public Nullable<int> Aid { get; set; }
    public Nullable<int> GDerece { get; set; }
    public Nullable<int> ADerece { get; set; }
    public string Gadi { get; set; }
    public string Aadi { get; set; }
    public string MsjBaslik { get; set; }
    public string MsjText { get; set; }
    public Nullable<System.DateTime> MsjTarih { get; set; }
    public Nullable<bool> Okundu { get; set; }
}

public partial class Ogrenci
{
    public int Id { get; set; }
    public Nullable<int> Hoca_ID { get; set; }
    public Nullable<bool> Hoca_Onay { get; set; }
    public string Ad { get; set; }
    public string No { get; set; }
    public string Sifre { get; set; }
    public string Mail { get; set; }
    public string Bolum { get; set; }
    public Nullable<int> Derece { get; set; }
    public Nullable<int> Tez_ID { get; set; }
    public Nullable<bool> Tez_Onay { get; set; }
    public Nullable<bool> durum { get; set; }

    public virtual Hoca Hoca { get; set; }
    public virtual Tarih Tarih { get; set; }
    public virtual Tez Tez { get; set; }
}

public partial class Rapor
{
    public int Id { get; set; }
    public Nullable<int> Hoca_Id { get; set; }
    public Nullable<int> Tez_Id { get; set; }
    public Nullable<int> Tarih_Id { get; set; }
    public string Ad { get; set; }
    public string Aciklama { get; set; }
    public string Dosya { get; set; }

    public virtual Hoca Hoca { get; set; }
    public virtual Tez Tez { get; set; }
}

public partial class Rapor_Tarih
{
    public int Id { get; set; }
    public Nullable<int> Hoca_Id { get; set; }
    public Nullable<System.DateTime> RaporBas { get; set; }
    public Nullable<System.DateTime> RaporBit { get; set; }
    public Nullable<int> tur { get; set; }

    public virtual Hoca Hoca { get; set; }
}

public partial class Sistem
{
    public int Id { get; set; }
    public Nullable<System.DateTime> DanismanSBas { get; set; }
    public Nullable<System.DateTime> DanismanSBit { get; set; }
    public Nullable<System.DateTime> TezSBas { get; set; }
    public Nullable<System.DateTime> TezSBit { get; set; }
}

public partial class Tarih
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Tarih()
    {
        this.Ogrenci = new HashSet<Ogrenci>();
    }

    public int Hoca_ID { get; set; }
    public Nullable<System.DateTime> RaporBas { get; set; }
    public Nullable<System.DateTime> RaporBit { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Ogrenci> Ogrenci { get; set; }
}

public partial class Tez
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Tez()
    {
        this.Ogrenci = new HashSet<Ogrenci>();
        this.Rapor = new HashSet<Rapor>();
    }

    public int Id { get; set; }
    public Nullable<int> Hoca_ID { get; set; }
    public string Konu { get; set; }
    public string Aciklama { get; set; }
    public Nullable<int> Tez_Limit { get; set; }
    public Nullable<int> Tez_Alan { get; set; }
    public string ResimAd { get; set; }
    public string ResimUzanti { get; set; }
    public Nullable<int> ResimDurum { get; set; }
    public Nullable<bool> durum { get; set; }
    public string keywords { get; set; }

    public virtual Hoca Hoca { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Ogrenci> Ogrenci { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Rapor> Rapor { get; set; }
}

public partial class Tez_Kitap
{
    public int Id { get; set; }
    public Nullable<int> Hoca_id { get; set; }
    public Nullable<int> Tez_id { get; set; }
    public Nullable<int> Ogr_id { get; set; }
    public string Dosya_Uzanti { get; set; }
    public Nullable<int> Dosya_ad { get; set; }
    public Nullable<int> Durum { get; set; }
}
