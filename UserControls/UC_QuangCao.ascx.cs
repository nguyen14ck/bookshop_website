using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_UC_QuangCao : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //dtlQuangCao.DataKeyNames = new string[] { "QuangCaoID" };
        dtlQuangCao.DataKeyField = "QuangCaoID";
        string lenh = "Select * From QuangCao";
        dtlQuangCao.DataSource = XLDL.DocBang(lenh);
        dtlQuangCao.DataBind();
    }
}