using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibDataDuoc
{
    public class PhieuThanhLy
    {
        public void saveData(ref String MaTL, String LOAITLID, String LOAITLIDo, DateTime Ngay)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.SAVEPHIEUTHANHLY";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "MaTL", "LOAITLID", "LOAITLIDO", "NGAY" };
            Object[] ThamTri = { MaTL, LOAITLID, LOAITLIDo, Ngay };
            MaTL = data.sExecuteNonQuery(ThamBien, ThamTri, "MaTL", 10);
        }
        public void deleteData(String MaTL)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DELETE FROM DUOC.PHIEUTHANHLY WHERE MaTL = '" + MaTL + "'";
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public void duyet(String MaTL)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.DUYETPHIEUTHANHLY";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            data.ExecuteNonQuery("MaTL", MaTL);
        }
        public DataTable getDataTable() 
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.PHIEUTHANHLY";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getDataTable(DateTime TuNgay, DateTime DenNgay)
        {
            String s = "SELECT PX.MaTL, PX.LOAITLID, PX.MAKHO, PX.NGAY, KH.TENLOAITL, KHO.TENKHO ";
            s += "FROM DUOC.PHIEUTHANHLY PX JOIN DUOC.LOAITHANHLY KH ON PX.LOAITLID = KH.LOAITLID JOIN DUOC.KHO KHO ON PX.MAKHO = KHO.MAKHO ";
            s += "WHERE NGAY BETWEEN ? AND ? ORDER BY PX.MaTL ";
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = s;
            data.CommandType = System.Data.CommandType.Text;
            String[] ThamBien = { "TUNGAY", "DENNGAY" };
            Object[] ThamTri = { TuNgay, DenNgay };
            return data.GetDataTable(ThamBien, ThamTri);
        }
        public DataRow getDataRow(String MaTL)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.PHIEUTHANHLY WHERE MaTL = '" + MaTL + "'";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
    }
}
