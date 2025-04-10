using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibDataDuoc
{
    public class SanPhamTon
    {
        public void saveData(String NamThang, String MaKho, String MaSPSD, String HanDung, Int16 SoLuong)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.SAVESANPHAMTON";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "NamThang", "MaKho", "MaSPSD", "HanDung", "SoLuong" };
            Object[] ThamTri = { NamThang, MaKho, MaSPSD, HanDung, SoLuong };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }
        public void updateHanDung(String NamThang, String MaKho, String MaSPSD, String HanDung)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "UPDATE DUOC.SANPHAMTON SET HANDUNG = ? WHERE NAMTHANG = ? AND MAKHO = ? AND MASPSD = ?";
            data.CommandType = System.Data.CommandType.Text;
            String[] ThamBien = { "HANDUNG", "NAMTHANG", "MAKHO", "MASPSD", };
            Object[] ThamTri = { HanDung, NamThang, MaKho, MaSPSD };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }
        public void saveData(String MaKho, String MaNCC, String NguonSPID, String NamThang, String MaSP, String HanDung, Decimal SoLuong, Decimal GiaXuat, Decimal GiaNhap)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.KHAIBAODUOCTON";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "MAKHO", "MANCC", "NGUONSPID", "NAMTHANG", "MASP", "HANDUNG", "SOLUONG", "GIAXUAT", "GIANHAP" };
            Object[] ThamTri = { MaKho, MaNCC, NguonSPID, NamThang, MaSP, HanDung, SoLuong, GiaXuat, GiaNhap };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }
        public void deleteData(String NamThang, String MaKho, String MaSPSD, String HanDung)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.DELDUOCTON";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "NAMTHANG", "MAKHO", "MASPSD", "HANDUNG" };
            Object[] ThamTri = { NamThang, MaKho, MaSPSD, HanDung };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }
        public DataTable getDataTable() 
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.SANPHAMTON";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getDataTable(String NamThang)
        {
            String s = "SELECT TON.MASPSD, SP.TENSP, SP.TENDONVI, SUBSTR(HANDUNG, 5,2) || '-' || SUBSTR(HANDUNG, 1, 4) AS HANDUNG, SUM(TON.SOLUONG) As SOLUONG, SD.GIAXUAT, SUM(TON.SOLUONG * SD.GIANHAP) AS THANHTIEN ";
            s += "FROM DUOC.SANPHAMTON TON JOIN DUOC.SANPHAMSD SD ON TON.MASPSD = SD.MASPSD	JOIN DUOC.VIEWSANPHAM SP ON SD.MASP = SP.MASP ";
            s += "WHERE NamThang = '" + NamThang + "' ";
            s += "GROUP BY TON.MASPSD, SP.TENSP, SP.TENDONVI, TON.HANDUNG, SD.GIAXUAT ";
            s += "ORDER BY TON.MASPSD ";
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = s;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getDataTable(String NamThang, String MaKho)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.LISTSANPHAMTON";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "NAMTHANG", "MAKHO" };
            Object[] ThamTri = { NamThang, MaKho };
            return data.GetDataTable(ThamBien, ThamTri);
        }
        public DataTable getDataTableAo(String NamThang, String MaKho)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.LISTSANPHAMTONAO";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "NAMTHANG", "MAKHO" };
            Object[] ThamTri = { NamThang, MaKho };
            return data.GetDataTable(ThamBien, ThamTri);
        }
        public DataRow getDataRow(String NamThang, String MaKho, String MaSPSD, String HanDung)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.SANPHAMTON WHERE NamThang = ? AND MaKho = ? AND MaSPSD = ? AND HanDung = ?";
            data.CommandType = System.Data.CommandType.Text;
            String[] ThamBien = { "NamThang", "MaKho", "MaSPSD", "HanDung" };
            Object[] ThamTri = { NamThang, MaKho, MaSPSD, HanDung };
            return data.GetDataRow(ThamBien, ThamTri);
        }
        public void updateTonAo(String NamThang, String MaKho, String MaSPSD, String HanDung, Double SoLuong)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "UPDATE DUOC.SANPHAMTON SET SOLUONGAO = SOLUONGAO - " + SoLuong.ToString() + "  WHERE NamThang = ? AND MaKho = ? AND MaSPSD = ? AND HanDung = ?";
            data.CommandType = System.Data.CommandType.Text;
            String[] ThamBien = { "NamThang", "MaKho", "MaSPSD", "HanDung" };
            Object[] ThamTri = { NamThang, MaKho, MaSPSD, HanDung };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }
        public DataTable getTheKho(String NamThang, String MaKho, String MaPS)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.THEKHO";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "NAMTHANG", "MAKHO", "MASP" };
            Object[] ThamTri = { NamThang, MaKho, MaPS };
            return data.GetDataTable(ThamBien, ThamTri);
        }
        public Double getTonMaSPDK(String NamThang, String MaKho, String MaSP)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.GETTONMASPDK";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "NAMTHANG", "MAKHO", "MASP" };
            Object[] ThamTri = { NamThang, MaKho, MaSP };
            DataRow result = data.GetDataRow(ThamBien, ThamTri);
            if (result == null || result["SoLuong"] == DBNull.Value)
                return 0;
            else
                return Double.Parse(result["SoLuong"].ToString());
        }
    }
}
