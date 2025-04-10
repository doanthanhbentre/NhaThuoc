using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibDataDuoc
{
    public class NguoiDung
    {
        public void saveData(String TenDangNhap, String MatKhau, String HoTen)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.SAVENGUOIDUNG";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "TenDangNhap", "MatKhau", "HoTen" };
            Object[] ThamTri = { TenDangNhap, MatKhau, HoTen };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }
        public void deleteData(String TenDangNhap)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DELETE FROM DUOC.NGUOIDUNG WHERE TenDangNhap = '" + TenDangNhap + "' AND UCASE(TENDANGNHAP) != 'ADMIN'";
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public DataTable getDataTable() 
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.NGUOIDUNG";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataRow getDataRow(String TenDangNhap)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.NGUOIDUNG WHERE UCASE(TenDangNhap) = '" + TenDangNhap.ToUpper() + "'";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
        public Boolean dangNhap(String TenDangNhap, String MatKhau)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT Count(*) FROM DUOC.NGUOIDUNG WHERE UCASE(TenDangNhap) = '" + TenDangNhap.ToUpper() + "' AND MatKhau = '" + MatKhau + "'";
            data.CommandType = System.Data.CommandType.Text;
            Object i = data.ExecuteScalar();
            return Int32.Parse(i.ToString()) > 0;
        }
        public void doiMatKhau(String TenDangNhap, String MatKhau)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "UPDATE DUOC.NGUOIDUNG SET MATKHAU = '" + MatKhau + "' WHERE UCASE(TenDangNhap) = '" + TenDangNhap.ToUpper() + "'";
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
    }
}
