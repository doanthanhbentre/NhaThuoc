using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibDataDuoc
{
    public class ChiTietTraNCC
    {
        public void saveData(String MAPTNCC, String MaSPSD, String HanDung, Single SoLuong)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.SAVECHITIETTRANCC";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "MAPTNCC", "MASPSD", "HANDUNG", "SOLUONG" };
            Object[] ThamTri = { MAPTNCC, MaSPSD, HanDung, SoLuong };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }
        public void deleteData(String MAPTNCC, String MaSPSD, String HanDung, Single SoLuong)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.DELCHITIETTRANCC";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "MAPTNCC", "MASPSD", "HANDUNG", "SOLUONG" };
            Object[] ThamTri = { MAPTNCC, MaSPSD, HanDung, SoLuong };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }
        public DataTable getDataTable() 
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.CHITIETTRANCC";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getDataTable(String MAPTNCC)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.LISTCHITIETTRANCC";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            return data.GetDataTable("MAPTNCC", MAPTNCC);
        }
        public DataRow getDataRow(String MAPTNCC, String MaSPSD)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.CHITIETTRANCC WHERE MAPTNCC = '" + MAPTNCC + "' AND MaSPSD = '" + MaSPSD + "'";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
    }
}
