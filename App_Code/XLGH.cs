using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for XLGH
/// </summary>
public class GioHang : DataTable 
{
    //- Constructor
	public GioHang()
	{
		//
		// TODO: Add constructor logic here
		//
        DataColumn colSachID=this.Columns.Add("SachID",typeof(System.Int32));
        this.Columns.Add("TenSach",typeof(System.String));
        this.Columns.Add("SoLuong", typeof(System.Int32));
        this.Columns.Add("GiaBan", typeof(System.Double));
        this.Columns.Add("ThanhTien", typeof(System.Double), "SoLuong*GiaBan");
        this.PrimaryKey = new DataColumn[] { colSachID };

	}
    //Properties
    public int TongMatHang
    {
        get { return this.Rows.Count; }
    }
    public double TongThanhTien
    {
        get 
        {
            double kq = 0;
            object _sum = this.Compute("Sum(ThanhTien)", "");
            if (_sum != DBNull.Value) kq = (double)_sum;
            return kq;
        }
    }
    public void them(int sachID, string tenSach, double giaBan)
    {
        // Kiểm tra tồn tại mặt hàng ... SachID 
        DataRow _row = this.Rows.Find(sachID);
        if (_row != null)
        {
            // Tăng số lượng lên 1
            int sl = (int)_row["Soluong"];
            _row["SoLuong"] = sl + 1;
        }
        else
        {
            // insert 1 dòng mới vào datatable gio hang

            DataRow _newRow = this.NewRow();
            _newRow["SachID"] = sachID;
            _newRow["TenSach"] = tenSach;
            _newRow["Soluong"] = 1;
            _newRow["GiaBan"] = giaBan;
            this.Rows.Add(_newRow);
        }
        this.AcceptChanges(); //Cần Update trước => VS2010: Update bao gồm cả AcceptChanges
    }
    public bool PhatSinhDonDatHang(int Kid)
    {
        string ngayHH = DateTime.Today.ToString("MM/dd/yyyy");
        string lenh1 = string.Format(@"Insert into DatHang(KhachHangid,NgayDatHang,TriGia) values ({0},'{1}',{2});
                                    Select @@Indentity From DatHang;", Kid, ngayHH, this.TongThanhTien);
        object kq = XLDL.ThucHienLenhTK(lenh1);
        int DHid = 0;
        if (kq != DBNull.Value) DHid = Convert.ToInt32(kq);
        foreach (DataRow r in this.Rows)
        {
            string lenh2 = string.Format("Insert into DatHangCT(DatHangID,SachID,Soluong,DonGia,ThanhTien) Values({0},{1},{2},{3},{4})",
                                        DHid, r["sachID"], r["Soluong"], r["GiaBan"], r["ThanhTien"]);
            XLDL.ThucHienLenh(lenh2);
        }
        return true;
    }
}