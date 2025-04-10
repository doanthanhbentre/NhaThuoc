using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibDataDuoc
{
    public class ChiTietNhap
    {
        public void saveData(String MAPN, String MASP, String QUICACHID, String SODANGKY, String SOLO, String HANDUNG, Double SOLUONGQUICACH, Int16 SOLUONGQUIDOI, Double DONGIAQUICACH, Double VAT, Double SOLUONG, Double GIANHAP, Double GIAXUAT, Double CHIETKHAU, Double THANHTIEN)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.SAVECHITIETNHAP";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "MAPN", "MASP", "QUICACHID", "SODANGKY", "SOLO", "HANDUNG", "SOLUONGQUICACH", "SOLUONGQUIDOI", "DONGIAQUICACH", "VAT", "SOLUONG", "GIANHAP", "GIAXUAT", "CHIETKHAU", "THANHTIEN" };
            Object[] ThamTri = { MAPN, MASP, QUICACHID, SODANGKY, SOLO, HANDUNG, SOLUONGQUICACH, SOLUONGQUIDOI, DONGIAQUICACH, VAT, SOLUONG, GIANHAP, GIAXUAT, CHIETKHAU, THANHTIEN };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }
        public void deleteData(String MaPN, String MaSP)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.DELCHITIETNHAP" ;
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "MaPN", "MaSP" };
            Object[] ThamTri = { MaPN, MaSP };
            data.ExecuteNonQuery(ThamBien, ThamTri);
        }
        public DataTable getDataTable() 
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.CHITIETNHAP";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
        public DataTable getDataTable(String MaPN)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.LISTCHITIETNHAP";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            return data.GetDataTable("MAPN", MaPN);
        }
        public DataRow getDataRow(String MaPN, String MaSP)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "SELECT * FROM DUOC.CHITIETNHAP WHERE MaPN = '" + MaPN + "' AND MaSP = '" + MaSP + "'";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
        public DataRow getDataRowLast(String MaSP)
        {
            String s = "SELECT * FROM DUOC.CHITIETNHAP CT JOIN DUOC.PHIEUNHAP PN ON CT.MAPN = PN.MAPN ";
            s += "WHERE MASP = '" + MaSP + "' AND PN.NGAY = (SELECT MAX(NGAY) FROM DUOC.CHITIETNHAP CT1 JOIN DUOC.PHIEUNHAP PN1 ON CT1.MAPN = PN1.MAPN WHERE MASP = '" + MaSP + "')";
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = s;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataRow();
        }
        public void updateHanDung(String MaPN, String MaSP, String HanDung){
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "UPDATE DUOC.CHITIETNHAP SET HANDUNG = '" + HanDung + "' WHERE MaPN = '" + MaPN + "' AND MaSP = '" + MaSP + "'";
            data.CommandType = System.Data.CommandType.Text;
            data.ExecuteNonQuery();
        }
        public DataTable getChiTietSoLo(String soLo)
        {
            String m_SQL = "";
            m_SQL += "SELECT PN.MAPN, PN.NGAY, NCC.TENNCC, CT.MASP, CT.MASPSD, SP.TENSP, SP.TENDONVI, CT.SOLO, ";
            m_SQL += "SUBSTR(HANDUNG, 5,2) || '-' || SUBSTR(HANDUNG, 1, 4) AS HANDUNG,  ";
            m_SQL += "CT.SOLUONG, SP.NHOMSPID, SP.TENNHOMSP ";
            m_SQL += "FROM DUOC.CHITIETNHAP CT ";
            m_SQL += "JOIN DUOC.VIEWSANPHAM SP ON CT.MASP = SP.MASP ";
            m_SQL += "JOIN DUOC.PHIEUNHAP PN ON CT.MAPN = PN.MAPN ";
            m_SQL += "JOIN DUOC.NHACUNGCAP NCC ON PN.MANCC = NCC.MANCC  ";
            m_SQL += "WHERE CT.SOLO LIKE '%" + soLo + "%' ";
            m_SQL += "ORDER BY CT.SOLO ";
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = m_SQL;
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();

        }
    }
}
