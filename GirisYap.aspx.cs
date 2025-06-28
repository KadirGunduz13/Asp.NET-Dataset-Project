using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class GirisYap : System.Web.UI.Page
{
    SqlConnection baglanti = new SqlConnection("Data Source=KADIR13\\SQLEXPRESS;Initial Catalog=BlogWebDB;Integrated Security=True;TrustServerCertificate=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sebder, EventArgs e)
    {
        baglanti.Open();
        SqlCommand komut = new SqlCommand("SELECT * FROM TBLADMIN WHERE kullanici=@p1 and sifre=@p2", baglanti);
        komut.Parameters.AddWithValue("@p1", TextBox1.Text);
        komut.Parameters.AddWithValue("@p2", TextBox2.Text);
        SqlDataReader dr = komut.ExecuteReader();
        if (dr.Read())
        {
            Response.Redirect("Hakkımda.aspx");
        }
        else
        {
            Response.Write("Hatalı Giriş");
        }
        baglanti.Close();
    }
}