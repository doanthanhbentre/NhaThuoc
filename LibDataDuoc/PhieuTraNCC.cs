using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibDataDuoc
{
    public class PhieuTraNCC
    {
        public void saveData(ref String MaPTNCC, String MaNCC, String MaKho, DateTime Ngay)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.SAVEPHIEUTRANCC";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "MAPTNCC", "MANCC", "MAKHO", "NGAY" };
            Object[] ThamTri = { MaPTNCC, MaNCC, MaKho, Ngay };
            MaPTNCC = data.sExecuteNonQuery(ThamBien, ThamTri, "MAPTNCC", 10);
        }
        public void deleteData(String MAPTNCC)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DELETE FROM DUOC.PHIEUTRANCC WHERE MAPTNCC = '" + MAPTNCC + "'";
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public void duyet(String MAPTNCC)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.DUYETPHIEUTRANCC";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            data.ExecuteNonQuery("MAPTNCC", MAPTNCC);
        }
        public DataTable getDataTable() 
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.PHIEUTRANCC";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getDataTable(DateTime TuNgay, DateTime DenNgay)
        {
            String s = "SELECT PX.MAPTNCC, PX.MANCC, PX.MAKHO, PX.NGAY, KH.TENNCC, KHO.TENKHO ";
            s += "FROM DUOC.PHIEUTRANCC PX JOIN DUOC.NHACUNGCAP KH ON PX.MANCC = KH.MANCC JOIN DUOC.KHO KHO ON PX.MAKHO = KHO.MAKHO ";
            s += "WHERE NGAY BETWEEN ? AND ? ORDER BY PX.MAPTNCC ";
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = s;
            data.CommandType = System.Data.CommandType.Text;
            String[] ThamBien = { "TUNGAY", "DENNGAY" };
            Object[] ThamTri = { TuNgay, DenNgay };
            return data.GetDataTable(ThamBien, ThamTri);
        }
        public DataRow getDataRow(String MAPTNCC)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.PHIEUTRANCC WHERE MAPTNCC = '" + MAPTNCC + "'";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
    }
}
