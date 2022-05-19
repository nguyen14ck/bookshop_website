using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class UserControls_UC_Sach : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string Cid = Request.QueryString["Cid"];
            string lenh = "";
            if (Cid == null)
            {
                lenh = "Select top 6 * From Sach order by Ngaycapnhat desc";
                tieuDe.Text = "&nbsp;&nbsp;SÁCH MỚI CẬP NHẬT";
            }
            else
            {
                lenh = "Select * from sach where ChudeID=" + Cid;
                DataTable bangChuDe = XLDL.DocBang("Select TenChuDe From Chude where ChudeID=" + Cid);
                tieuDe.Text = "SÁCH THEO CHỦ ĐỀ -" + bangChuDe.Rows[0]["TenChuDe"].ToString().ToUpper();
            }
            dtlSach.DataKeyField = "SachID";
            dtlSach.DataSource = XLDL.DocBang(lenh);
            dtlSach.DataBind();
        }
    }

    protected void dtlSach_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "ChonMua")
        {
            int idS = (int)dtlSach.DataKeys[e.Item.ItemIndex];

            HyperLink hplTenSach = (HyperLink)e.Item.FindControl("hplTenSach");
            double giaBan = Convert.ToDouble(e.CommandArgument);

            GioHang bangGioHang = (GioHang)Session["GioHang"];
            bangGioHang.them(idS, hplTenSach.Text, giaBan);
        }
    }
}