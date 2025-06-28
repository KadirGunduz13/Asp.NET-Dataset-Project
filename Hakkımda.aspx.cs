using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Hakkımda : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {

            DataSetTableAdapters.TBLHAKKIMDATableAdapter dt = new DataSetTableAdapters.TBLHAKKIMDATableAdapter();
            TextBox1.Text = dt.HakkımdaListele()[0].ad;
            TextBox2.Text = dt.HakkımdaListele()[0].soyad;
            TextBox3.Text = dt.HakkımdaListele()[0].adres;
            TextBox4.Text = dt.HakkımdaListele()[0].mail;
            TextBox5.Text = dt.HakkımdaListele()[0].telefon;
            TextBox6.Text = dt.HakkımdaListele()[0].kisaNot;
            TextBox7.Text = dt.HakkımdaListele()[0].fotograf;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.TBLHAKKIMDATableAdapter dt1 = new DataSetTableAdapters.TBLHAKKIMDATableAdapter();
        dt1.HakkımdaGuncelle(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text);
        Response.Redirect("default.aspx");
    }
}