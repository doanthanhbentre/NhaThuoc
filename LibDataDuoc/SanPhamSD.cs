using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibDataDuoc
{
    public class SanPhamSD
    {
        public void updateGiaXuat(String MaSPSD, Decimal GiaXuat)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "UPDATE DUOC.SANPHAMSD SET GIAXUAT = ? WHERE MASPSD = '" + MaSPSD + "'";
            data.CommandType = System.Data.CommandType.Text;
            String[] ThamBien = { "GIAXUAT" };
            Object[] ThamTri = { GiaXuat };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }
        public DataTable getDataTable()
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT SD.MASPSD, SP.TENSP, SP.TENDONVI, SD.GIAXUAT FROM DUOC.SANPHAMSD SD JOIN DUOC.VIEWSANPHAM SP ON SD.MASP = SP.MASP ORDER BY SP.TENSP";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataRow getDataRow(String MaSP)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT ROUND(GIAXUAT,0) AS GIAXUAT, ROUND(GIANHAP,0) AS GIANHAP FROM DUOC.SANPHAMSD WHERE MASP = '" + MaSP + "' FETCH FIRST 1 ROW ONLY";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
    }
}
