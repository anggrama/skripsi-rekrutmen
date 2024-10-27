using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DataAccessUsers : DataAccessBase
    {
        public DataTable GetDataTableUsers()
        {
            DataTable dt;

            try
            {
                dt = GetDataTable("SELECT UserId,UserName,Pass,PandaId,UserRole,IsActive FROM M_User WHERE UserRole != 'SuperAdmin'");
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

            return dt;
        }

        public DataTable GetDataTableUsers(string userId)
        {
            DataTable dt;

            try
            {
                var query = string.Format("SELECT * FROM M_User WHERE UserId = @userId");
                var cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@userId", userId);
                dt = GetDataTable(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        public DataTable GetDataTablePanda()
        {
            DataTable dt;

            try
            {
                dt = GetDataTable("SELECT WilayahId,WilayahName FROM M_Panda");
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

            return dt;
        }

        public void SaveUsers(DataStruct.DataStructUsers args)
        {
            try
            {
                dbLinq.usp_M_Users_Save(args.UserId, args.UserName, args.Password, args.UserRole, args.PandaId, args.IsActive, args.CreatedBy);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }

}
