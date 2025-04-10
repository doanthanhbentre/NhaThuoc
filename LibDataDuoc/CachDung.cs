using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibDataDuoc
{
    public class CachDung
    {
        public DataTable getDataTable()
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.CACHDUNG ORDER BY NOIDUNG";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }

    }
}
