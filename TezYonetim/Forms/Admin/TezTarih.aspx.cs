﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Admin_TezTarih : System.Web.UI.Page
{
    TezDBEntities db;
    Sistem trh;
    protected void Page_Load(object sender, EventArgs e)
    {
        db = new TezDBEntities();
        trh = db.Sistem.Where(q => q.Id == 1).FirstOrDefault();

        Label1.Text = "Başlangıç " + trh.TezSBas.ToString();
        Label2.Text = "Bitiş " + trh.TezSBit.ToString();
    }
    protected void btnGiris_Click(object sender, EventArgs e)
    {
        //DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss").Replace(' ', 'T');
        //Tarih kayıt
        trh.TezSBas = DateTime.Parse(TBas.Text.Replace("T", " "));
        trh.TezSBit = DateTime.Parse(TBit.Text.Replace("T", " "));
        db.SaveChanges();

        //Label yenileme
        Label1.Text = "Başlangıç " + trh.TezSBas.ToString();
        Label2.Text = "Bitiş " + trh.TezSBit.ToString();


    }
}