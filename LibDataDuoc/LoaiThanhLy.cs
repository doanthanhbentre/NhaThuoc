using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibDataDuoc
{
    public class LoaiThanhLy
    {
        public void saveData(ref String LoaiTLID, String TenLoaiTL)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.SAVELOAITHANHLY";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "LoaiTLID", "TenLoaiTL" };
            Object[] ThamTri = { LoaiTLID, TenLoaiTL };
            LoaiTLID = data.sExecuteNonQuery(ThamBien, ThamTri, "LoaiTLID", 2);
        }
        public void deleteData(String LoaiTLID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DELETE FROM DUOC.LOAITHANHLY WHERE LoaiTLID = '" + LoaiTLID + "'";
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public DataTable getDataTable() 
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.LOAITHANHLY";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataRow getDataRow(String LoaiTLID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.LOAITHANHLY WHERE LoaiTLID = '" + LoaiTLID + "'";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
    }
}
