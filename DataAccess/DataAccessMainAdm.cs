using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DataAccessMainAdm : DataAccessMain
    {
        public DataTable GetDataTableLanud(string pandaId, string pangkat, string GelombangId)
        {
            DataTable dt;
            string query;

            try
            {
                query = string.Format("SELECT * FROM vStatistik WHERE PandaId like '{0}' AND Pangkat='{1}' AND GelombangID='{2}'", pandaId, pangkat, GelombangId);
                dt = GetDataTable(query);
            }
            catch (Exception)
            {

                throw;
            }

            return dt;
        }
        public int GetCount_TotNasAnimo(string pangkat, string GelombangId)
        {
            try
            {
                var query = string.Format("SELECT COUNT(1) AS TotNasAnimo FROM M_Pendaftar WHERE Pangkat like @pangkat AND GelombangId = @GelombangId");
                var cmd = new SqlCommand(query,oCn);
                cmd.Parameters.AddWithValue("@pangkat", pangkat);
                cmd.Parameters.AddWithValue("@GelombangId", GelombangId);
                
                return Convert.ToInt32(ExecuteScalar(cmd));
            }
            catch (Exception)
            {
                
                throw;
            }

           
        }
        public int GetCount_TotNasPeserta(string pangkat,string GelombangId)
        {

            try
            {
                var query = string.Format("SELECT COUNT(1) AS TotNasPeserta FROM M_Pendaftar WHERE  Pangkat like @pangkat AND GelombangId = @GelombangId AND NoPeserta IS NOT NULL");
                var cmd = new SqlCommand(query, oCn);
                cmd.Parameters.AddWithValue("@pangkat", pangkat);
                cmd.Parameters.AddWithValue("@GelombangId", GelombangId);
                return Convert.ToInt32(ExecuteScalar(cmd));
            }
            catch (Exception)
            {
                
                throw;
            }

        }
        public int GetCount_TotLulusDaerah(string pangkat,string GelombangId)
        {
           

            try
            {
                var query = string.Format("SELECT COUNT(1) AS LulusDaerah FROM M_Pendaftar WHERE Pangkat like '{0}' AND GelombangId ='{1}' AND NoPeserta IS NOT NULL AND LulusDaerah = 1", pangkat, GelombangId);
                var cmd = new SqlCommand(query, oCn);
                cmd.Parameters.AddWithValue("@pangkat", pangkat);
                cmd.Parameters.AddWithValue("@GelombangId", GelombangId);
                return Convert.ToInt32(ExecuteScalar(cmd));

            }
            catch (Exception)
            {
                throw;
            }

           
        }
        public int GetCount_TotLulusPeserta(string pangkat,string GelombangId)
        {

            try
            {
                var query = string.Format("SELECT COUNT(1) AS LulusPusat FROM M_Pendaftar WHERE Pangkat like '{0}' AND GelombangId ='{1}' AND NoPeserta IS NOT NULL AND LulusPusat = 1", pangkat, GelombangId);
                var cmd = new SqlCommand(query, oCn);
                cmd.Parameters.AddWithValue("@pangkat", pangkat);
                cmd.Parameters.AddWithValue("@GelombangId", GelombangId);
                return Convert.ToInt32(ExecuteScalar(cmd));

            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
