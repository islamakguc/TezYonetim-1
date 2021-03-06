﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TezBaseUser
/// </summary>
public class TezBaseUser : System.Web.UI.Page
{
    public TezBaseUser()
    {
    }
    protected override void OnInit(EventArgs e)
    {
        TezDBEntities db = new TezDBEntities();
        var Ogrenci = db.Ogrenci.ToList();
        if (Session["Id"] != null)
        {
            if ((int)Session["derece"] == 1) //1 veritabanında Hoca demek
            {
                Response.Redirect(@"~/Forms/Hoca/index.aspx");
            }
            if ((int)Session["derece"] == 0)
            {
                Response.Redirect(@"~/Forms/Admin/index.aspx");
            }
        }
        else
        {
            if (Request.Cookies["MyCookie"] != null)
            {
                string No = Request.Cookies["MyCookie"]["No"];
                string sifre = Request.Cookies["MyCookie"]["sifre"];
                Ogrenci ogrenci = db.Ogrenci.Where(u => u.No == No && u.Sifre == sifre).FirstOrDefault();
                if (ogrenci != null)
                {
                    AppKontrol.id = ogrenci.Id;
                    AppKontrol.name = ogrenci.Ad;
                    AppKontrol.derece = Convert.ToInt32(ogrenci.Derece);
                    Response.Redirect(@"~/Default.aspx");
                }
            }
            else
            {
               Response.Redirect(@"~/Default.aspx");
            }           
        }
        base.OnInit(e);
    }
}