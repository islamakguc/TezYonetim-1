﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forms_Admin_HocaEkle : TezBaseAdmin
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnGiris_Click(object sender, EventArgs e)
    {
        TezDBEntities db = new TezDBEntities();

        string sifrem = Sifreleme.Sifrele(Request["Sifre"].Trim());
        string no = Request["E-mail"].Trim();
        if (Request["Name"].Trim() == "" || Request["Sifre"].Trim() == "" || Request["E-mail"].Trim() == "" || Request["Ders"].Trim() == "")
        {
            LabelSignUP.Text = "Lütfen Boş Geçmeyiniz";
        }
        else
        {
            if (db.Hoca.Where(w => w.Mail == no).Any())
            {
                LabelSignUP.Text = "Bu Kullanıcı Sistemde Mevcut";
            }
            else
            {
                Hoca hoca = new Hoca();

                hoca.Ad = Request["Name"].Trim();
                hoca.Sifre = sifrem;
                hoca.Mail = Request["E-mail"].Trim();
                hoca.Ders = Request["Ders"].Trim();
                hoca.Derece = 1;
                db.Hoca.Add(hoca);
                db.SaveChanges();
                Response.Redirect(@"~/Default.aspx");
            }

        }
    }
}