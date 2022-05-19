using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_UC_GioHangTT : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.PreRender += new EventHandler(Page_PreRender);
    }

    void Page_PreRender(object sender, EventArgs e)
    {
        GioHang gioHang = (GioHang)Session["GioHang"];
        tongTien.Text = "Trị Giá: " + gioHang.TongThanhTien.ToString("#,##0 VNĐ");
    }
}