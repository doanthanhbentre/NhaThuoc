using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibDataDuoc
{
    public class KhoaPhong
    {
        public DataTable getDataTable()
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT MAKP, TENKP || CASE LOAI WHEN 1 THEN ' (KB)' WHEN 2 THEN ' (ĐT)' ELSE ' (PCN)' END AS TENKP FROM DUOC.KHOAPHONG WHERE HIEULUC = 1 ORDER BY MAKP";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getDataTable(Int32 Loai)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT MAKP, TENKP FROM DUOC.KHOAPHONG WHERE LOAI = " + Loai.ToString() + " AND HIEULUC = 1 ORDER BY MAKP";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }

    }
}
