﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Duzenle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Id"] != null && Request.QueryString["Id"] != null )
        {
            if ((int)Session["derece"] == 2) //2 veritabanında öğrenci demek
            {
                Response.Redirect(@"~/User.aspx");
            }
        

        if (!Page.IsPostBack)
            {
                TezDBEntities db = new TezDBEntities();
               int idd = int.Parse(Request.QueryString["Id"]);
                var guncelKayit = db.Ogrenci.Find(idd);
                if (guncelKayit!=null)
                {
                    TextBox1.Text = guncelKayit.No;
                    TextBox2.Text = guncelKayit.Ad;
                    TextBox4.Text = guncelKayit.Mail;
                    TextBox5.Text = guncelKayit.Bolum;
                }
                else
                {
                    Response.Redirect(@"~/Default.aspx");
                }
                
            }

        }
        else {
            Response.Redirect(@"~/Default.aspx");
        }
        
    }
    protected void btnGuncelle_Click(object sender, EventArgs e)
    {
        TezDBEntities db = new TezDBEntities();
        int idd = int.Parse(Request.QueryString["Id"]);
        var guncelKayit = db.Ogrenci.Find(idd);
        guncelKayit.No = TextBox1.Text;
        guncelKayit.Ad = TextBox2.Text;
        guncelKayit.Mail = TextBox4.Text;
        guncelKayit.Bolum = TextBox5.Text;
        db.SaveChanges();
        Response.Redirect(@"~/Admin.aspx");
    }
}