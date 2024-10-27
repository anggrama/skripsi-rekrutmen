using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataAccess
{
    public class DataAccessDetailAnimo : DataAccessBase
    {
        public DataTable GetDataTableParameter(string parameterType, string pangkat)
        {
            DataTable dt;

            try
            {
                dt = GetDataTable(string.Format("SELECT ParameterID,ParameterName FROM M_Parameter WHERE ParameterType ='{0}' AND Is{1}=1 ORDER BY ParameterID", parameterType, pangkat));
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }

        public DataTable GetDataTableParameter(string parameterType, string pangkat, int ParameterID)
        {
            DataTable dt;

            try
            {
                dt = GetDataTable(string.Format("SELECT ParameterID,ParameterName FROM M_Parameter WHERE ParameterType ='{0}' AND Is{1}=1 AND ParameterID={2} ORDER BY ParameterID", parameterType, pangkat, ParameterID));
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }

        public DataTable GetDataTablePanda(string WilayahID)
        {
            DataTable dt;

            try
            {
                dt = GetDataTable(string.Format("SELECT WilayahName FROM M_Panda WHERE WilayahId = '{0}'", WilayahID));
            }
            catch (Exception)
            {

                throw;
            }

            return dt;
        }

        public DataTable GetDataTableDataProfil(string noAnimo)
        {
            DataTable dt;

            try
            {
                dt = GetDataTable(string.Format("SELECT a.* ,b.* FROM M_Pendaftar a INNER JOIN M_Pendaftar_Profile b ON a.email = b.useremail WHERE a.NoAnimo ='{0}' AND a.NoPeserta IS NULL", noAnimo));
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }

   
     
        public void AddPeserta(string noAnimo,string modifiedBy)
        {
            try
            {
                dbLinq.usp_M_Pendaftar_AddPeserta(noAnimo,modifiedBy);
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

    }
}
