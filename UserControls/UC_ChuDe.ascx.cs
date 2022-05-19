using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_UC_ChuDe : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dtlChuDe.DataSource = XLDL.DocBang("Select * From ChuDe");
            dtlChuDe.DataBind();
        }
    }
}