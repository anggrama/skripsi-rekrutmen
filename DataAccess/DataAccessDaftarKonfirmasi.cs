using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DataAccessDaftarKonfirmasi : DataAccessMain
    {
        public DataTable GetDataTableUserPass(string noAnimo,string pangkat)
        {
            DataTable dt;

            try
            {
                string query = string.Format("SELECT a.UserEmail,a.Pass FROM M_Pendaftar_Profile a INNER JOIN M_Pendaftar b ON a.UserEmail = b.Email WHERE b.NoAnimo = @noAnimo AND b.Pangkat = @pangkat");
                var cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@noAnimo", noAnimo);
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
