using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibDataDuoc
{
    public class NhomSP
    {
        public void saveData(ref String NhomSPID, String LoaiSPID, String TenNhomSP)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.SAVENHOMSP";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "NHOMSPID", "LOAISPID", "TENNHOMSP" };
            Object[] ThamTri = { NhomSPID, LoaiSPID, TenNhomSP };
            NhomSPID = data.sExecuteNonQuery(ThamBien, ThamTri, "NHOMSPID", 2);
        }
        public void deleteData(String NhomSPID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DELETE FROM DUOC.NHOMSP WHERE NhomSPID = '" + NhomSPID + "'";
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public DataTable getDataTable() 
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.NHOMSP";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getDataTable(String LoaiSPID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.NHOMSP WHERE LOAISPID = '" + LoaiSPID + "'";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataRow getDataRow(String NhomSPID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.NHOMSP WHERE NhomSPID = '" + NhomSPID + "'";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
    }
}
