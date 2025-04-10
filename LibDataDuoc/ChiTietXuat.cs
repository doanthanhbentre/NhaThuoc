using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibDataDuoc
{
    public class ChiTietXuat
    {
        public void saveData(String MaPX, String MaSPSD, String HanDung, Single SoLuong, Int32 XuatAo, String CachDung)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.SAVECHITIETXUAT";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "MAPX", "MASPSD", "HANDUNG", "SOLUONG", "XUATAO", "CACHDUNG" };
            Object[] ThamTri = { MaPX, MaSPSD, HanDung, SoLuong, XuatAo, CachDung };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }
        public void deleteData(String XuatID, Int32 XuatAo)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.DELCHITIETXUAT";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "XUATID", "XUATAO" };
            Object[] ThamTri = { XuatID, XuatAo };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }
        public DataTable getDataTable() 
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.CHITIETXUAT";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getDataTable(String MaPX)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.LISTCHITIETXUAT";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            return data.GetDataTable("MaPX", MaPX);
        }
        public DataRow getDataRow(String MaPX, String MaSPSD)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.CHITIETXUAT WHERE MaPX = '" + MaPX + "' AND MaSPSD = '" + MaSPSD + "'";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
        public void updateCachDung(String MaPX, String MaSPSD, String CachDung)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "UPDATE DUOC.CHITIETXUAT SET CACHDUNG = '" + CachDung + "'  WHERE MaPX = '" + MaPX + "' AND MaSPSD = '" + MaSPSD + "'";
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public void updateSoLuong(String MaPX, String MaSPSD, Decimal SoLuong)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "UPDATE DUOC.CHITIETXUAT SET SOLUONG = '" + SoLuong.ToString() + "'  WHERE MaPX = '" + MaPX + "' AND MaSPSD = '" + MaSPSD + "'";
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
    }
}
