using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

public partial class UserControls_UC_Footerl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string dc = ConfigurationManager.AppSettings["DiaChiCty"];
        lbl_DiaChiCty.Text = dc;
    }
}