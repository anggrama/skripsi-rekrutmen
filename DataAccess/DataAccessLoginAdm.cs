using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DataAccessLoginAdm : DataAccessMain
    {
        public DataTable GetDataTableUserInfo(string user, string pass)
        {
            DataTable dt;

            try
            {
                string sql = string.Format("SELECT UserId,UserName,PandaId,UserRole FROM M_User WHERE UserId = @user AND Pass = @pass AND IsActive = 1");
                var cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", pass);
                dt = GetDataTable(cmd);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

            return dt;
        }

        public DataTable GetDataTableGelombang()
        {
            DataTable dt;

            try
            {
                dt = GetDataTable(string.Format("SELECT TOP 1 TahunPendaftaran,GelombangID FROM M_Gelombang WHERE IsActive = 1 ORDER BY GelombangID desc"));
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

            return dt;
        }
    }
}
