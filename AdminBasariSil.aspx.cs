using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminBasariSil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt16(Request.QueryString["id"]);


        DataSetTableAdapters.TBLBASARILARTableAdapter dt = new DataSetTableAdapters.TBLBASARILARTableAdapter();
        dt.BasariSil(Convert.ToInt16(x));
        Response.Redirect("AdminBasarilar.aspx");
    }
}