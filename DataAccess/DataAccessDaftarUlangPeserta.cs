using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DataAccessDaftarUlangPeserta : DataAccessMain
    {

        string sqlDefault = "SELECT a.NoAnimo,b.Nama FROM M_Pendaftar a INNER JOIN M_Pendaftar_Profile b on a.email = b.userEmail WHERE a.NoPeserta IS NULL";
        public DataTable GetDataTableAnimo(string gelombangID,string pangkat, string pandaId)
        {
            DataTable dt;

            try
            {
                string sql = sqlDefault + string.Format(" AND a.GelombangID = @gelombangId AND a.Pangkat like @pangkat AND a.PandaId = @pandaId");
                var cmd = new SqlCommand(sql, oCn);
                cmd.Parameters.AddWithValue("@gelombangId", gelombangID);
                cmd.Parameters.AddWithValue("@pangkat", pangkat);
                cmd.Parameters.AddWithValue("@pandaId", pandaId);
                dt = GetDataTable(cmd);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

            return dt;
        }

        public DataTable GetDataTableAnimo(string gelombangID,string pangkat)
        {
            DataTable dt;

            try
            {
                string sql = sqlDefault + string.Format(" AND a.GelombangID = @gelombangId AND a.Pangkat like @pangkat");
                var cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@gelombangId", gelombangID);
                cmd.Parameters.AddWithValue("@pangkat", pangkat);
                dt = GetDataTable(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }
    }
}
