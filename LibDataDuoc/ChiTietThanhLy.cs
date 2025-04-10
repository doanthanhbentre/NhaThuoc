using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibDataDuoc
{
    public class ChiTietThanhLy
    {
        public void saveData(String MaTL, String MaSPSD, String HanDung, Single SoLuong)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.SAVECHITIETTHANHLY";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "MATL", "MASPSD", "HANDUNG", "SOLUONG" };
            Object[] ThamTri = { MaTL, MaSPSD, HanDung, SoLuong };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }
        public void deleteData(String MaTL, String MaSPSD, String HanDung, Single SoLuong)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.DELCHITIETTHANHLY";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "MaTL", "MASPSD", "HANDUNG", "SOLUONG" };
            Object[] ThamTri = { MaTL, MaSPSD, HanDung, SoLuong };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }
        public DataTable getDataTable() 
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.CHITIETTHANHLY";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getDataTable(String MaTL)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.LISTCHITIETTHANHLY";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            return data.GetDataTable("MaTL", MaTL);
        }
        public DataRow getDataRow(String MaTL, String MaSPSD)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.CHITIETTHANHLY WHERE MaTL = '" + MaTL + "' AND MaSPSD = '" + MaSPSD + "'";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
    }
}
