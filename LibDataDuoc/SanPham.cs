using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibDataDuoc
{
    public class SanPham
    {
        public void saveData(ref String MASP, String DONVIID, String NHOMSPID, String TENSP, String HOATCHAT, String HANGSX, String NUOCSX, Int32 TRONGNUOC, Int32 HIEULUC)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.SAVESANPHAM";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "MASP", "DONVIID", "NHOMSPID", "TENSP", "HOATCHAT", "HANGSX", "NUOCSX", "TRONGNUOC", "HIEULUC" };
            Object[] ThamTri = { MASP, DONVIID, NHOMSPID, TENSP, HOATCHAT, HANGSX, NUOCSX, TRONGNUOC, HIEULUC };
            MASP = data.sExecuteNonQuery(ThamBien, ThamTri, "MASP", 10);
        }
        public void deleteData(String MaSP)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DELETE FROM DUOC.SANPHAM WHERE MaSP = '" + MaSP + "'";
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public void DoiNhom(String MaSP, String NhomSPID)
        {
            String sql = "Update Duoc.SanPham Set NhomSPID = '" + NhomSPID + "' Where MaSP = '" + MaSP + "'";
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = sql;
            data.CommandType = CommandType.Text;
            data.ExecuteNonQuery();
        }
        public DataTable getDataTable() 
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.VIEWSANPHAM";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getDataTable(String NhomSPID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.VIEWSANPHAM WHERE NhomSPID = '" + NhomSPID + "'";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataRow getDataRow(String MaSP)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.SANPHAM WHERE MaSP = '" + MaSP + "'";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
        public String getTenDuoc(String TenSP)
        {
            String result = "";
            String s = "SELECT TENSP, TENDONVI, TENNHOMSP ";
            s += "FROM DUOC.SANPHAM SP JOIN DUOC.DONVI DV ON SP.DONVIID = DV.DONVIID JOIN DUOC.NHOMSP NH ON SP.NHOMSPID = NH.NHOMSPID ";
            s += "WHERE UCASE(TENSP) = '" + TenSP.ToUpper() +"'";
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = s;
            data.CommandType = System.Data.CommandType.Text;
            DataView dataView = data.GetDataTable().DefaultView;
            foreach (DataRowView r in dataView)
            {
                result += "- " + r["TenSP"].ToString() + ": Đơn vị: " + r["TenDonVi"].ToString() + ", Nhóm dược: " + r["TenNhomSP"].ToString() + "\n";
            }
            if (result != "")
                result = "Tên sản phẩm [" + TenSP.ToUpper() + "] đang tồn tại: \n" + result;
            return result;
        }
        public DataTable getListSanPham(String LoaiSPID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.LISTSANPHAM";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            return data.GetDataTable("LOAISPID", LoaiSPID);
        }
        public String getLoaiSP(String MaSP)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT NH.LOAISPID FROM DUOC.SANPHAM SP JOIN DUOC.NHOMSP NH ON SP.NHOMSPID = NH.NHOMSPID WHERE SP.MASP = '" + MaSP + "'";
            data.CommandType = System.Data.CommandType.Text;
            return data.ExecuteScalar().ToString();

        }
    }
}
