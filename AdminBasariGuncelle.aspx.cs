using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminBasariGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt16(Request.QueryString["id"]);
        TxtId.Text = x.ToString();
        TxtId.Enabled = false;

        if (Page.IsPostBack == false)
        {
            DataSetTableAdapters.TBLBASARILARTableAdapter dt = new DataSetTableAdapters.TBLBASARILARTableAdapter();
            TxtBasari.Text = dt.BasariGetir(Convert.ToInt16(x))[0].basari;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.TBLBASARILARTableAdapter dt = new DataSetTableAdapters.TBLBASARILARTableAdapter();
        dt.BasariGuncelle(TxtBasari.Text, Convert.ToInt16(TxtId.Text));
        Response.Redirect("AdminBasarilar.aspx");
    }
}