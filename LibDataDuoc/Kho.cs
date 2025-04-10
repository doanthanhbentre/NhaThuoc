using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibDataDuoc
{
    public class Kho
    {
        public void saveData(ref String MaKho, String TenKho, Int32 HieuLuc)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.SAVEKHO";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "MAKHO", "TENKHO", "HIEULUC" };
            Object[] ThamTri = { MaKho, TenKho, HieuLuc };
            MaKho = data.sExecuteNonQuery(ThamBien, ThamTri, "MAKHO", 2);
        }
        public void deleteData(String MaKho)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DELETE FROM DUOC.KHO WHERE MaKho = '" + MaKho + "'";
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public DataTable getDataTable() 
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.KHO";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataRow getDataRow(String MaKho)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.KHO WHERE MaKho = '" + MaKho + "'";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
    }
}
