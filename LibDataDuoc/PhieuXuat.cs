using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibDataDuoc
{
    public class PhieuXuat
    {
        public void saveData(ref String MaPX, String MaKH, String MaKho, DateTime Ngay, String MaBS, String ChanDoan, String MaKP, String LoiDan)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.SAVEPHIEUXUAT";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "MAPX", "MAKH", "MAKHO", "NGAY", "MABS", "CHANDOAN", "MAKP", "LOIDAN" };
            Object[] ThamTri = { MaPX, MaKH, MaKho, Ngay, MaBS, ChanDoan, MaKP, LoiDan };
            MaPX = data.sExecuteNonQuery(ThamBien, ThamTri, "MAPX", 10);            
        }
        public void deleteData(String MaPX)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DELETE FROM DUOC.PHIEUXUAT WHERE MaPX = '" + MaPX + "'";
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public void updateDuyet(String MaPX, DateTime NgayDuyet, String TenDangNhap)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "UPDATE DUOC.PHIEUXUAT SET DADUYET = 1, NGAYDUYET = '" + NgayDuyet.ToString("yyyy-MM-dd") + "', TENDANGNHAP = '" + TenDangNhap + "' WHERE MAPX = '" + MaPX + "'";
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public void duyet(String MaPX)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.DUYETPHIEUXUAT";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            data.ExecuteNonQuery("MAPX", MaPX);
        }
        public DataTable getDataTable() 
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.PHIEUXUAT";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getDataTable(DateTime TuNgay, DateTime DenNgay)
        {
            String s = "SELECT PX.MAPX, PX.MAKH, PX.MAKHO, PX.NGAY, KH.TENKH, KHO.TENKHO ";
            s += "FROM DUOC.PHIEUXUAT PX JOIN DUOC.KHACHHANG KH ON PX.MAKH = KH.MAKH JOIN DUOC.KHO KHO ON PX.MAKHO = KHO.MAKHO ";
            s += "WHERE PX.DADUYET = 1 AND NGAY BETWEEN ? AND ? ORDER BY PX.MAPX ";
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = s;
            data.CommandType = System.Data.CommandType.Text;
            String[] ThamBien = { "TUNGAY", "DENNGAY" };
            Object[] ThamTri = { TuNgay, DenNgay };
            return data.GetDataTable(ThamBien, ThamTri);
        }
        public DataRow getDataRow(String MaPX)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.PHIEUXUAT WHERE MaPX = '" + MaPX + "'";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
        public DataTable listKeDonHienHanh(String MaKP)
        {
            String sql = "SELECT PX.DADUYET, PX.MAPX, KH.TENKH, KH.NAMSINH, KH.DIACHI, PX.CHANDOAN ";
            sql += "FROM DUOC.KHACHHANG KH JOIN DUOC.PHIEUXUAT PX ON KH.MAKH = PX.MAKH ";
            sql += "WHERE MAKP = '" + MaKP +"' AND NGAY = CURRENT DATE ";
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = sql;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable listChoDuyet(DateTime ngay)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.LISTCHODUYET";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            return data.GetDataTable("NGAY", ngay);
        }
        public DataTable getDonThuoc(String MaPX)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.GETDONTHUOC";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            return data.GetDataTable("MAPX", MaPX);
        }
        public DataTable getBienLai(String MaPX)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.GETBIENLAI";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            return data.GetDataTable("MAPX", MaPX);
        }
        public DataTable getCacLanKeDon(String MaKH)
        {
            String m_SQl = "SELECT PX.MAPX, PX.NGAY, BS.HOTEN AS BACSI, KP.TENKP, PX.CHANDOAN ";
            m_SQl += "FROM DUOC.PHIEUXUAT PX ";
            m_SQl += "JOIN DUOC.BACSI BS ON PX.MABS = BS.MABS ";
            m_SQl += "JOIN DUOC.KHOAPHONG KP ON PX.MAKP = KP.MAKP ";
            m_SQl += "WHERE PX.MAKH = '" + MaKH + "' ";
            m_SQl += "ORDER BY PX.MAPX DESC ";
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = m_SQl;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public void copyDonThuoc(String MaPX, String MaBS, String MaKP)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.COPYDONTHUOC";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "MAPX", "MABS", "MAKP" };
            Object[] ThamTri = { MaPX, MaBS, MaKP};
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }
    }
}
