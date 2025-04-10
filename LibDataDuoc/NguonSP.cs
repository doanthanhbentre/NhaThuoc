using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibDataDuoc
{
    public class NguonSP
    {
        public void saveData(ref String NguonSPID, String TenNguonSP)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.SAVENGUONSP";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "NGUONSPID", "TENNGUONSP" };
            Object[] ThamTri = { NguonSPID, TenNguonSP };
            NguonSPID = data.sExecuteNonQuery(ThamBien, ThamTri, "NGUONSPID", 2);
        }
        public void deleteData(String NguonSPID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DELETE FROM DUOC.NGUONSP WHERE NguonSPID = '" + NguonSPID + "'";
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public DataTable getDataTable() 
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.NGUONSP";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataRow getDataRow(String NguonSPID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.NGUONSP WHERE NguonSPID = '" + NguonSPID + "'";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
    }
}
