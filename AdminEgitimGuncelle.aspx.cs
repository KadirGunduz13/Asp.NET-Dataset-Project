using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminEgitimGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt16(Request.QueryString["id"]);
        TxtId.Enabled = false;
        TxtId.Text = x.ToString();

        if (Page.IsPostBack == false)
        {
            DataSetTableAdapters.TBLEGITIMTableAdapter dt = new DataSetTableAdapters.TBLEGITIMTableAdapter();
            TxtBaslik.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].baslik;
            TxtAltBaslik.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].altBaslik;
            TxtAciklama.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].aciklama;
            TxtGano.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].gano;
            TxtTarih.Text = dt.EgitimGetir(Convert.ToInt16(x))[0].tarih;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.TBLEGITIMTableAdapter dt = new DataSetTableAdapters.TBLEGITIMTableAdapter();
        dt.EgitimGuncelle(TxtBaslik.Text, TxtAltBaslik.Text, TxtAciklama.Text, TxtGano.Text, TxtTarih.Text, Convert.ToInt16(TxtId.Text));
        Response.Redirect("AdminEgitimler.aspx");
    }
}