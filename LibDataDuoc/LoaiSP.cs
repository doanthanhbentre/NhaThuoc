using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibDataDuoc
{
    public class LoaiSP
    {
        public void saveData(ref String LoaiSPID, String TenLoaiSP)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.SAVELOAISP";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "LOAISPID", "TENLOAISP" };
            Object[] ThamTri = { LoaiSPID, TenLoaiSP };
            LoaiSPID = data.sExecuteNonQuery(ThamBien, ThamTri, "LOAISPID", 2);
        }
        public void deleteData(String LoaiSPID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DELETE FROM DUOC.LOAISP WHERE LOAISPID = '" + LoaiSPID + "'";
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public DataTable getDataTable() 
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.LOAISP";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataRow getDataRow(String LoaiSPID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.LOAISP WHERE LOAISPID = '" + LoaiSPID + "'";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
    }
}
