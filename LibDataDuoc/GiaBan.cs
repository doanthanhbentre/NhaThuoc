using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibDataDuoc
{
    public class GiaBan
    {
        public Int32 getTyLe(Decimal giaMua)
        {
            Int32 m_GiaMua = 0;
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Select TyLe From Duoc.GiaBan Where GiaCao = (Select Min(GiaCao) From Duoc.GiaBan Where GiaCao >= " + giaMua.ToString() +")";
            data.CommandType = System.Data.CommandType.Text;
            DataRow row = data.GetDataRow();
            if (row != null)
                m_GiaMua = Int32.Parse(row["TyLe"].ToString());
            else
                m_GiaMua = 0;
            return m_GiaMua;
        }
        public DataTable getGiaBan()
        {
            LibDataDB2.ASDataProvider data = new LibDataDB2.ASDataProvider();
            data.CommandText = "Select * From Duoc.GiaBan Order by STT";
            data.CommandType = System.Data.CommandType.Text;
            return data.GetDataTable();
        }
    }
}
