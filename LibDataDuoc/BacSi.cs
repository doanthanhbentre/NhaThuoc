using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibDataDuoc
{
    public class BacSi
    {
        public DataTable getDataTable()
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.BACSI ORDER BY HOTEN";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }

    }
}
