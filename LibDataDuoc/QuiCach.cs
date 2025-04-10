using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibDataDuoc
{
    public class QuiCach
    {
        public void saveData(ref String QuiCachID, String TenQuiCach)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.SAVEQUICACH";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "QuiCachID", "TenQuiCach" };
            Object[] ThamTri = { QuiCachID, TenQuiCach };
            QuiCachID = data.sExecuteNonQuery(ThamBien, ThamTri, "QuiCachID", 3);
        }
        public void deleteData(String QuiCachID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DELETE FROM DUOC.QUICACH WHERE QuiCachID = '" + QuiCachID + "'";
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public DataTable getDataTable() 
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.QUICACH ORDER BY QuiCachID";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataRow getDataRow(String QuiCachID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.QUICACH WHERE QuiCachID = '" + QuiCachID + "'";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
    }
}
