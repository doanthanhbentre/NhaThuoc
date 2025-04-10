using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibDataDuoc
{
    public class KhachHang
    {
        public void saveData(ref String MaKH, String TenKH, String DiaChi, String DienThoai, Int32 HieuLuc, Int32 NamSinh, Int32 GioiTinh)
        {
            
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.SAVEKHACHHANG";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "MAKH", "TENKH", "DIACHI", "DIENTHOAI", "HIEULUC", "NAMSINH", "GioiTinh" };
            Object[] ThamTri = { MaKH, TenKH, DiaChi, DienThoai, HieuLuc, NamSinh, GioiTinh };
            MaKH = data.sExecuteNonQuery(ThamBien, ThamTri, "MAKH", 10);
        }
        public void deleteData(String MaKH)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DELETE FROM DUOC.KHACHHANG WHERE MaKH = '" + MaKH + "'";
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public DataTable getDataTable() 
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.KHACHHANG ORDER BY MAKH";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataRow getDataRow(String MaKH)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.KHACHHANG WHERE MaKH = '" + MaKH + "'";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
    }
}
