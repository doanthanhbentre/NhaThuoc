using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibDataDuoc
{
    public class ThoiGianKhoaSo
    {
        public void saveData(DateTime TuNgay, DateTime DenNgay)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.SAVETHOIGIANKHOASO";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "TUNGAY", "DENNGAY" };
            Object[] ThamTri = { TuNgay, DenNgay};
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }
        public void deleteData(String NamThang)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DELETE FROM DUOC.THOIGIANKHOASO WHERE NAMTHANG = '" + NamThang + "'";
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public DataTable getDataTable() 
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT SUBSTR(NAMTHANG, 5,2) || '-' || SUBSTR(NAMTHANG, 1, 4) AS THANGNAM, TUNGAY, DENNGAY, DAKHOA FROM DUOC.THOIGIANKHOASO ORDER BY NAMTHANG DESC";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataRow getDataRow(String NamThang)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.THOIGIANKHOASO WHERE NamThang = '" + NamThang + "'";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
    }
}
