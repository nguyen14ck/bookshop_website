using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_UC_SachCTl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string Sid=Request.QueryString["Sid"];
        if (Sid != null) load_grid(Sid);
    }
    private void load_grid(string id)
    {
        string lenh = "Select Sach.*,TenNhaXuatBan From Sach Inner join NhaXuatBan on Sach.NhaXuatBanID=NhaXuatBan.NhaXuatBanID Where SachID="+id;

        dtlSach.DataKeyField = "SachID";
        dtlSach.DataSource = XLDL.DocBang(lenh);
        dtlSach.DataBind();

    }
    protected void dtlSach_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            int i = e.Item.ItemIndex;
            int _ID = (int)dtlSach.DataKeys[i];
            string lenh = string.Format(@"Select TacGia.TacGiaID,TenTacGia+ '('+ VaiTro +')' as ThongTin
                                        From TacGia Inner Join ThamGia On TacGia.TacGiaID=ThamGia.TacGiaID 
                                        Where SachID={0} Order by Vitri", _ID);

            //Tham Chiếu đến BulltedList dsTacGia
            BulletedList dsTacGia = (BulletedList)e.Item.FindControl("dsTacGia");

            //Gán nguồn cho dsTacGia
            dsTacGia.DataTextField = "Thongtin";
            dsTacGia.DataValueField = "TacGiaID";
            dsTacGia.DataSource = XLDL.DocBang(lenh);
            dsTacGia.DataBind();
        }
    }
}