using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataAccess
{
    public class DataAccessRekapData : DataAccessBase
    {

        string sqlDefault = "SELECT {2},COUNT(a.NoAnimo) Animo,COUNT(a.NoPeserta) Peserta," +
                            "SUM(CASE WHEN ISNULL(a.LulusDaerah,0) = 1 THEN 1 ELSE 0 END) LulusDaerah," +
                            "SUM(CASE WHEN ISNULL(a.LulusPusat,0) = 1 THEN 1 ELSE 0 END) LulusPusat " +
                            "FROM dbo.M_Pendaftar a INNER JOIN dbo.M_Pendaftar_Profile b ON a.Email = b.UserEmail";

        string inner = " INNER JOIN M_Parameter c ON b.{4}=c.ParameterID ";
        string where = " WHERE a.GelombangID = {0} AND a.Pangkat = '{1}' AND a.PandaId Like '{3}%' GROUP BY {2}";
        //public DataTable GetDataTableRekapData(string gelombangID, string pangkat, string parameter, string pandaId,string param)
        //{
        //    DataTable dt = null ;
        //    string query;

        //    try
        //    {
        //        query = string.Format(sqlDefault + " WHERE a.GelombangID = '{0}' AND a.Pangkat like '{1}' AND a.PandaId = '{3}%' AND a.NoPeserta {4} NULL GROUP BY b.{2},a.LulusDaerah,a.LulusPusat", gelombangID, pangkat, parameter, pandaId, param);
        //        dt = GetDataTable(query);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //    return dt;
        //}

        public DataTable GetDataTableRekapData(string gelombangID, string pangkat, string parameter, string pandaId)
        {
            DataTable dt = null;
            string query;

            try
            {
                string fieldName = "";
                if (parameter.ToLower() == "pendidikan" || parameter.ToLower() == "agama")
                {
                    fieldName = "c.ParameterName";
                    query = sqlDefault + inner + where;
                }
                else
                {
                    fieldName = parameter;
                    query = sqlDefault + where;
                }
                    
                    

                query = string.Format(query , gelombangID, pangkat, fieldName, pandaId,parameter);
                dt = GetDataTable(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }


    }
}
