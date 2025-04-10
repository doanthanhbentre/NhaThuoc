using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibDataDuoc
{
    public class BaoCao
    {
        public DataTable baoCaoNXT(String NamThang, String MaKho, String LoaiGia)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            if (LoaiGia == "I")
                data.CommandText = "DUOC.BAOCAONXTGIANHAP";
            else
                data.CommandText = "DUOC.BAOCAONXTGIAXUAT";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "NAMTHANG", "MAKHO" };
            Object[] ThamTri = { NamThang, MaKho };
            return data.GetDataTable(ThamBien, ThamTri);
        }
        public DataTable baoCaoNXT(String TuThang, String DenThang, String LoaiSPID, String LoaiGia)
        {
            //LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            //if (LoaiGia == "I")
            //    data.CommandText = "DUOC.BAOCAONXT_IN";
            //else
            //    data.CommandText = "DUOC.BAOCAONXT_OUT";
            //data.CommandType = System.Data.CommandType.StoredProcedure;
            //String[] ThamBien = { "TUTHANG", "DENTHANG", "MAKHO" };
            //Object[] ThamTri = { TuThang, DenThang, MaKho };
            //return data.GetDataTable(ThamBien, ThamTri);

            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            if (LoaiGia == "I")
                data.CommandText = "DUOC.BAOCAONXT_INNEW";
            else
                data.CommandText = "DUOC.BAOCAONXT_OUTNEW";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "TUTHANG", "DENTHANG", "LOAISPID" };
            Object[] ThamTri = { TuThang, DenThang, LoaiSPID };
            return data.GetDataTable(ThamBien, ThamTri);

        }
        public DataTable baoCaoDoanhThu(DateTime TuNgay, DateTime DenNgay)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.BAOCAOLOINHUAN";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "TUNGAY", "DENNGAY" };
            Object[] ThamTri = { TuNgay, DenNgay };
            return data.GetDataTable(ThamBien, ThamTri);
        }
        public DataTable baoCaoBS(DateTime TuNgay, DateTime DenNgay)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.BAOCAOBS";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "TUNGAY", "DENNGAY" };
            Object[] ThamTri = { TuNgay, DenNgay };
            return data.GetDataTable(ThamBien, ThamTri);
        }
        public DataTable baoCaoTN(DateTime TuNgay, DateTime DenNgay)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.BAOCAOTN";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "TUNGAY", "DENNGAY" };
            Object[] ThamTri = { TuNgay, DenNgay };
            return data.GetDataTable(ThamBien, ThamTri);
        }
        //public DataTable baoCaoNhapKhoTH(DateTime TuNgay, DateTime DenNgay, String TenLoaiSP, String LoaiSPID)
        //{
        //    LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
        //    data.CommandText = "DUOC.BAOCAONHAPKHOTH";
        //    data.CommandType = System.Data.CommandType.StoredProcedure;
        //    String[] ThamBien = { "TUNGAY", "DENNGAY" };
        //    Object[] ThamTri = { TuNgay, DenNgay };
        //    return data.GetDataTable(ThamBien, ThamTri);
        //}
        public DataTable baoCaoNhapKhoTH(DateTime TuNgay, DateTime DenNgay, String TenLoaiSP, String LoaiSPID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.BAOCAONHAPKHOTH";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "TUNGAY", "DENNGAY", "LOAISPID" };
            Object[] ThamTri = { TuNgay, DenNgay, LoaiSPID };
            return data.GetDataTable(ThamBien, ThamTri);
        }

        public DataTable baoCaoNhapKhoCT(DateTime TuNgay, DateTime DenNgay, String LoaiSPID)
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "DUOC.BAOCAONHAPKHOCT";
            data.CommandType = System.Data.CommandType.StoredProcedure;
            String[] ThamBien = { "TUNGAY", "DENNGAY" };
            Object[] ThamTri = { TuNgay, DenNgay };
            return data.GetDataTable(ThamBien, ThamTri);
        }
        //public DataTable baoCaoNhapKhoCT(DateTime TuNgay, DateTime DenNgay, String LoaiSPID)
        //{
        //    LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
        //    data.CommandText = "DUOC.BAOCAONHAPKHOCT";
        //    data.CommandType = System.Data.CommandType.StoredProcedure;
        //    String[] ThamBien = { "TUNGAY", "DENNGAY", "LOAISPID" };
        //    Object[] ThamTri = { TuNgay, DenNgay, LoaiSPID };
        //    return data.GetDataTable(ThamBien, ThamTri);
        //}
    }
}
