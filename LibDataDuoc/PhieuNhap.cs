using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibDataDuoc
{
    public class PhieuNhap
    {
        public void saveData(ref String MAPN, String MANCC, String NGUONSPID, String MAKHO, DateTime NGAY, String SOHD, DateTime NGAYHD, Decimal CHIETKHAU)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.SAVEPHIEUNHAP";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "MAPN", "MANCC", "NGUONSPID", "MAKHO", "NGAY", "SOHD", "NGAYHD", "CHIETKHAU" };
            Object[] ThamTri = { MAPN, MANCC, NGUONSPID, MAKHO, NGAY, SOHD, NGAYHD, CHIETKHAU };
            MAPN = data.sExecuteNonQuery(ThamBien, ThamTri, "MAPN", 10);            
        }
        public void deleteData(String MaPN)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DELETE FROM DUOC.PHIEUNHAP WHERE MaPN = '" + MaPN + "'";
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public DataTable getDataTable() 
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.PHIEUNHAP";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getDataTable(DateTime TuNgay, DateTime DenNgay, Boolean Duyet)
        {
            String s= "SELECT PN.MAPN, PN.MANCC, PN.NGUONSPID, PN.MAKHO, PN.NGAY, PN.SOHD, PN.NGAYHD, NCC.TENNCC, NG.TENNGUONSP, KH.TENKHO, SUM(CT.THANHTIEN) AS THANHTIEN, SUM(CT.CHIETKHAU) AS CHIETKHAU ";
            s += "FROM DUOC.PHIEUNHAP PN JOIN DUOC.NHACUNGCAP NCC ON PN.MANCC = NCC.MANCC JOIN DUOC.NGUONSP NG ON PN.NGUONSPID = NG.NGUONSPID JOIN DUOC.KHO KH ON PN.MAKHO = KH.MAKHO ";
            s += "JOIN DUOC.CHITIETNHAP CT ON PN.MAPN = CT.MAPN ";
            if (Duyet)
                s += "WHERE DADUYET = 1 AND NGAY BETWEEN ? AND ? ";
            else
                s += "WHERE DADUYET = 0 AND NGAY BETWEEN ? AND ? ";
            s += "GROUP BY PN.MAPN, PN.MANCC, PN.NGUONSPID, PN.MAKHO, PN.NGAY, PN.SOHD, PN.NGAYHD, NCC.TENNCC, NG.TENNGUONSP, KH.TENKHO ";
            s += "ORDER BY PN.MAPN DESC";
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = s;
            data.CommandType = System.Data.CommandType.Text;
            String[] ThamBien = { "TUNGAY", "DENNGAY" };
            Object[] ThamTri = { TuNgay, DenNgay };
            return data.GetDataTable(ThamBien,  ThamTri);
        }
        public DataRow getDataRow(String MaPN)
        {
            String s = "SELECT PN.MAPN, PN.MANCC, PN.NGUONSPID, PN.MAKHO, PN.NGAY, PN.SOHD, PN.NGAYHD, PN.CHIETKHAU, NCC.TENNCC, NG.TENNGUONSP, KH.TENKHO ";
            s += "FROM DUOC.PHIEUNHAP PN JOIN DUOC.NHACUNGCAP NCC ON PN.MANCC = NCC.MANCC JOIN DUOC.NGUONSP NG ON PN.NGUONSPID = NG.NGUONSPID JOIN DUOC.KHO KH ON PN.MAKHO = KH.MAKHO ";
            s += "WHERE MaPN = '" + MaPN + "'";
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = s;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
        public String getMaPN(String SoHD)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT MAX(MAPN) FROM DUOC.PHIEUNHAP WHERE SOHD = '" + SoHD + "'";
            data.CommandType = System.Data.CommandType.Text;
            return data.ExecuteScalar().ToString();
        }
    }
}
