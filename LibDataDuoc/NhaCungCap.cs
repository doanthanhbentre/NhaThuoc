using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibDataDuoc
{
    public class NhaCungCap
    {
        public void saveData(ref String MaNCC, String TenNCC, String DiaChi, String SoTaiKhoan, String DienThoai)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.SAVENHACUNGCAP";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "MANCC", "TENNCC", "DIACHI", "SOTAIKHOAN", "DIENTHOAI" };
            Object[] ThamTri = { MaNCC, TenNCC, DiaChi, SoTaiKhoan, DienThoai };
            MaNCC = data.sExecuteNonQuery(ThamBien, ThamTri, "MANCC", 5);
        }
        public void deleteData(String MaNCC)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DELETE FROM DUOC.NHACUNGCAP WHERE MaNCC = '" + MaNCC + "'";
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public DataTable getDataTable() 
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.NHACUNGCAP";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataRow getDataRow(String MaNCC)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.NHACUNGCAP WHERE MaNCC = '" + MaNCC + "'";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
    }
}
