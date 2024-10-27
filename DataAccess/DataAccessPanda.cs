using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataAccess
{
    public class DataAccessPanda : DataAccessBase
    {
        public DataTable GetDataTablePanda()
        {
            DataTable dt;

            try
            {
                //dt = GetDataTable("SELECT WilayahId,WilayahName,IsTaruna,IsBintara,IsTamtama,IsActive,IsLaki,IsPerempuan,kotama FROM M_Panda ORDER BY kotama,WilayahId");
                dt = GetDataTable("SELECT * FROM M_Panda ORDER BY kotama,WilayahId");
            }
            catch (Exception)
            {
                
                throw;
            }

            return dt;
        }

        public DataTable GetDataTablePandaDetail(string wilayahId)
        {
            DataTable dt;

            try
            {
                dt = GetDataTable(string.Format("SELECT WilayahId,WilayahName,IsTaruna,IsBintara,IsTamtama,IsActive,IsLaki,IsPerempuan,kotama FROM M_Panda WHERE WilayahId = '{0}'", wilayahId));
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

            return dt;
        }

        public void PandaSave(DataStruct.DataStructPanda args)
        {
            try
            {
                dbLinq.usp_M_Panda_Save(args.wilayahId,args.wilayahName,args.isTaruna,args.isBintara,args.isTamtama,args.CreatedBy,args.IsActive,args.isLakiTaruna,args.isPerempuanTaruna,args.isLakiBintara,args.isPerempuanBintara,args.isLakiTamtama,args.isPerempuanTamtama,args.kotama);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}
