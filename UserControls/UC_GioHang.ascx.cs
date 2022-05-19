using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class UserControls_GioHang : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            XuatGioHang();
        }
    }

    public void XuatGioHang()
    {
        GioHang bangGioHang = (GioHang)Session["GioHang"];
        grwGioHang.DataKeyNames = new[] { "SachID" };
        grwGioHang.DataSource = bangGioHang;
        grwGioHang.DataBind();
        lblTongtien.Text = bangGioHang.TongThanhTien.ToString("#,##0 VNĐ");
        lblTongMH.Text = bangGioHang.TongMatHang.ToString();
    }

    protected void grwGioHang_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grwGioHang.EditIndex = e.NewEditIndex;
        XuatGioHang();
    }

    protected void grwGioHang_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        grwGioHang.EditIndex = -1;
        XuatGioHang();
    }

    protected void grwGioHang_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        int i = e.RowIndex;
        int Sid = Convert.ToInt32(grwGioHang.DataKeys[i].Value);
        TextBox soLuong = (TextBox)grwGioHang.Rows[i].Cells[1].Controls[0];

        GioHang bangGioHang = (GioHang)Session["GioHang"];
        bangGioHang.Rows.Find(Sid)["SoLuong"]=Convert.ToInt32(soLuong.Text);

        grwGioHang.EditIndex = -1;

        XuatGioHang();
    }

    protected void grwGioHang_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "xoa")
        {
            GioHang bangGioHang = (GioHang)Session["GioHang"];
            if (bangGioHang.TongMatHang > 0)
            {
                for (int i = 0; i < grwGioHang.Rows.Count; i++)
                {
                    CheckBox chk = (CheckBox)grwGioHang.Rows[i].FindControl("chkChon");
                    if (chk.Checked)
                    {
                        int Sid = (int)grwGioHang.DataKeys[i].Value;
                        DataRow dongXoa = bangGioHang.Rows.Find(Sid);
                        bangGioHang.Rows.Remove(dongXoa);
                    }
                }

                XuatGioHang();
            }

        }
        
    }

    protected void btnDatmua_Click(object sender, EventArgs e)
    {
        GioHang bangGioHang = (GioHang)Session["GioHang"];
        int Kid = (int)Session["KhachHangID"];

        if (bangGioHang.PhatSinhDonDatHang(Kid))
        {
            Session["GioHang"] = new GioHang();
            XuatGioHang();
            lblTongThongbao.Text = "Đơn Đặt Hàng Đã Được Ghi Nhận !!!";
        }
        else 
        {
            lblTongThongbao.Text = "Error ... Không thể phát sinh đơn đặt hàng !!!";
        }
        MultiView1.ActiveViewIndex = 1;
    }
}