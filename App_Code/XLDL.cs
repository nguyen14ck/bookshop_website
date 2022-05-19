using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class XLDL
{
    //public static string chuoiKetNoi = @"Data Source=.\SQL2012;Initial Catalog=QLBS;Integrated Security=SSPI;";
    public static string chuoiKetNoi = @"Data Source=.\NPNSF3_SQLSERVER; Initial Catalog=Spl_KHTN_QLBS; Integrated Security=SSPI;";

    //public static string chuoiKetNoi = ConfigurationManager.ConnectionStrings["QLBSConnectionString"].ConnectionString;

    static SqlConnection ketNoi;
    public static DataTable DocBang(string lenh)
    {//Select
        DataTable bang = new DataTable();
        try
        {
            if (ketNoi == null) ketNoi = new SqlConnection(chuoiKetNoi);
            SqlDataAdapter da = new SqlDataAdapter(lenh, ketNoi);
            da.FillSchema(bang, SchemaType.Mapped);
            da.Fill(bang);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return bang;
    }
    public static int ThucHienLenh(string lenh)
    {//Insert,Update,Delete
        int kq;
        try
        {
            if (ketNoi == null) ketNoi = new SqlConnection(chuoiKetNoi);
            if (ketNoi.State == ConnectionState.Closed) ketNoi.Open();
            SqlCommand cmd = new SqlCommand(lenh, ketNoi);
            kq = cmd.ExecuteNonQuery();
        }
        catch (SqlException)
        {
            kq= -1;
        }
        finally { ketNoi.Close(); }

        return kq;
    }
    public static object ThucHienLenhTK(string lenh)
    {//Insert,Update,Delete
        object kq;
        try
        {
            if (ketNoi == null) ketNoi = new SqlConnection(chuoiKetNoi);
            if (ketNoi.State == ConnectionState.Closed) ketNoi.Open();
            SqlCommand cmd = new SqlCommand(lenh, ketNoi);
            kq = cmd.ExecuteScalar();
        }
        catch (SqlException)
        {
            kq = -1;
        }
        finally { ketNoi.Close(); }

        return kq;
    }
}
