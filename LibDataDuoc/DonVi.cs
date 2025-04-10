using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibDataDuoc
{
    public class DonVi
    {
        public void saveData(ref String DonViID, String TenDonVi)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.SAVEDONVI";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "DONVIID", "TENDONVI" };
            Object[] ThamTri = { DonViID, TenDonVi };
            DonViID = data.sExecuteNonQuery(ThamBien, ThamTri, "DONVIID", 3);
        }
        public void deleteData(String DonViID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DELETE FROM DUOC.DONVI WHERE DonViID = '" + DonViID + "'";
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public DataTable getDataTable() 
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.DONVI ORDER BY TENDONVI";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataRow getDataRow(String DonViID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.DONVI WHERE DonViID = '" + DonViID + "'";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
    }
}
