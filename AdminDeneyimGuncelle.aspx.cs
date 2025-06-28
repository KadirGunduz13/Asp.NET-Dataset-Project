using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminDeneyimGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt16(Request.QueryString["id"]);
        TxtId.Enabled = false;
        TxtId.Text = x.ToString();

        if (Page.IsPostBack == false)
        {
            DataSetTableAdapters.TBLDENEYIMTableAdapter dt = new DataSetTableAdapters.TBLDENEYIMTableAdapter();
            TxtBaslik.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].baslik;
            TxtAltBaslik.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].altBaslik;
            TxtAciklama.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].aciklama;
            TxtTarih.Text = dt.DeneyimGetir(Convert.ToInt16(x))[0].tarih;
        }
    }

    protected void BtnGuncelle_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.TBLDENEYIMTableAdapter dt = new DataSetTableAdapters.TBLDENEYIMTableAdapter();
        dt.DeneyimGuncelle(TxtBaslik.Text, TxtAltBaslik.Text, TxtAciklama.Text, TxtTarih.Text, Convert.ToInt16(TxtId.Text));
        Response.Redirect("AdminDeneyimler.aspx");
    }
}