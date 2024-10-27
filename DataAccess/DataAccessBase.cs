using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class DataAccessBase : IDisposable
    {
        protected SqlConnection oCn;
        public dbLinqDataContext dbLinq;

        //string mailServer;
        //int mailPort;

        public void Dispose()
        {
            if (oCn != null)
            {
                oCn.Dispose();
                oCn = null;
            }
        }

        public DataAccessBase()
        {

            oCn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ToString());
            dbLinq = new dbLinqDataContext(oCn);

        }

        protected int ExecuteQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, oCn);
            int rowAffected = 0;
            try
            {
                oCn.Open();
                rowAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (oCn != null)
                    oCn.Close();
            }
            return rowAffected;
        }

        protected int ExecuteQuery(string query, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand(query,oCn);
            int rowAffected = 0;
            cmd.Parameters.AddRange(param);
            try
            {
                oCn.Open();
                rowAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (oCn != null)
                    oCn.Close();
            }
            return rowAffected;
        }

        protected int ExecuteQuery(string query, SqlCommand cmd)
        {
            cmd.CommandText = query;
            int rowAffected = 0;
            try
            {
                rowAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rowAffected;
        }

        protected int ExecuteStoredProcedure(string sp_name, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand(sp_name, oCn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            int rowAffected = 0;
            cmd.Parameters.AddRange(param);
            try
            {
                oCn.Open();
                rowAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (oCn != null)
                    oCn.Close();
            }
            return rowAffected;
        }

        protected int ExecuteStoredProcedure(SqlTransaction transaction, SqlCommand cmd)
        {
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            int rowAffected = 0;
            try
            {
                rowAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rowAffected;
        }

        protected Object ExecuteScalar(string query)
        {
            SqlCommand cmd = new SqlCommand(query, oCn);
            Object value = null;
            try
            {
                oCn.Open();
                value = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (oCn != null)
                    oCn.Close();
            }
            return value;

        }
        protected Object ExecuteScalar(string query,SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand(query, oCn);
            if (param != null)
                cmd.Parameters.AddRange(param);

            Object value = null;
            try
            {
                oCn.Open();
                value = cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (oCn != null)
                    oCn.Close();
            }
            return value;

        }


        protected object ExecuteScalar(SqlCommand cmd)
        {
            cmd.Connection = oCn;
            Object value = null;
            try
            {
                oCn.Open();
                value = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (oCn != null)
                    oCn.Close();
            }
            return value;

        }

        protected DataTable GetDataTable(string query)
        {

            SqlDataAdapter da = new SqlDataAdapter(query, oCn);
            DataTable dt = new DataTable();

            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;

        }

        protected DataTable GetDataTable(string query, SqlParameter[] param)
        {

            SqlCommand cmd = new SqlCommand(query, oCn);
            if (param != null)
                cmd.Parameters.AddRange(param);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                da.Fill(dt);
            }
            catch (Exception)
            {
                throw;
            }

            return dt;

        }

        protected DataTable GetDataTable(SqlCommand cmd)
        {
            cmd.Connection = oCn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;

        }

        protected DataTable GetDataTable(string query, string tableName)
        {

            SqlDataAdapter da = new SqlDataAdapter(query, oCn);
            DataTable dt = new DataTable(tableName);
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;

        }

        public DataTable GetDataTableOledb(string filename, string query)
        {

            string oledbcnstr = String.Format("Data Source={0};Provider=Microsoft.Jet.Oledb.4.0;Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1;\"", filename);
            System.Data.OleDb.OleDbConnection oledbcn = new System.Data.OleDb.OleDbConnection(oledbcnstr);

            System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(query, oledbcn);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;

        }

        public DataTable GetDataTableOleAceDb(string filename, string query)
        {

            string oledbcnstr = String.Format("Data Source={0};Provider=Microsoft.ACE.OLEDB.12.0;Extended Properties=\"Excel 12.0;HDR=Yes;\"", filename);
            System.Data.OleDb.OleDbConnection oledbcn = new System.Data.OleDb.OleDbConnection(oledbcnstr);

            oledbcn.Open();
            DataTable dtWorksheet = oledbcn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, null);
            oledbcn.Close();
            System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(query, oledbcn);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;

        }
    }
}
