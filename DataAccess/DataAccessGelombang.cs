using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataAccess
{
    public class DataAccessGelombang : DataAccessBase
    {
        public DataTable GetDataTableGelombang(string pangkat)
        {
            DataTable dt = null;

            try
            {
                string sql = string.Format("SELECT GelombangID,GelombangKe,TahunPendaftaran,RangeFrom,RangeTo,BornFrom,BornTo,Pangkat,IsActive FROM M_Gelombang WHERE Pangkat like '{0}'", pangkat);
                dt = GetDataTable(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }

        public DataTable GetDataTableGelombangDetail(int gelombangID)
        {
            DataTable dt;

            try
            {
                string sql = string.Format("SELECT GelombangKe,TahunPendaftaran,RangeFrom,RangeTo,Pangkat,IsActive FROM M_Gelombang WHERE GelombangID = '{0}'", gelombangID);
                dt = GetDataTable(sql);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

            return dt;
        }

        public void SaveGelombang(DataStruct.DataStructGelombang args)
        {
            try
            {
                dbLinq.usp_M_Gelombang_Save(args.GelombangID, args.GelombangKe, args.TahunPendaftaran, args.RangeFrom, args.RangeTo, args.BornFrom, args.BornTo, args.Pangkat, args.IsActive, args.CreatedBy);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}
