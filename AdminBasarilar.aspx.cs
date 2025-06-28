using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminBasarilar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSetTableAdapters.TBLBASARILARTableAdapter dt = new DataSetTableAdapters.TBLBASARILARTableAdapter();
        Repeater1.DataSource = dt.BasarılarListesi();
        Repeater1.DataBind();
    }
}