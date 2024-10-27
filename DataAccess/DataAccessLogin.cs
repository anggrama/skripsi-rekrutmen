using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DataAccessLogin : DataAccessMain
    {
        public DataTable GetDataTableInfo(string pangkat)
        {
            DataTable dt;

            try
            {
                string query = string.Format("SELECT Pengumuman,Persyaratan,Lokasi,Jadwal,MateriSeleksi,Panduan FROM M_Info WHERE Pangkat = @pangkat");
                var cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@pangkat", pangkat);
                dt = GetDataTable(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        public string GetDataTable_User(string email,string pass)
        {
            string sql = string.Format("SELECT Nama FROM M_Pendaftar_Profile WHERE UserEmail = @email AND Pass = @pass");
            try
            {
                var cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@pass", pass);
                return Convert.ToString(ExecuteScalar(cmd));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetDataTableGelombangDaftar(string pangkat)
        {
            DataTable dt;

            try
            {
                string query = string.Format("SELECT GelombangKe,TahunPendaftaran FROM M_Gelombang WHERE RangeFrom <= CAST(GETDATE() as date) AND RangeTo >= CAST(GETDATE() as date) AND Pangkat like @pangkat");
                var cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@pangkat", pangkat);
                dt = GetDataTable(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }
        public DataTable GetDataTableInfoLulus(string pangkat)
        {
            DataTable dt;

            try
            {
                string query = string.Format("SELECT GelombangID FROM M_Info WHERE Pangkat=@pangkat");
                var cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@pangkat", pangkat);
                dt = GetDataTable(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }

        public DataTable GetDataTablePengumumanKelulusan(string pangkat, int gelombangID)
        {
            DataTable dt;

            try
            {
                string query = string.Format("SELECT NoPeserta,Nama FROM M_Pendaftar WHERE Pangkat=@pangkat AND GelombangID=@gelombangId AND NoPeserta IS NOT NULL");
                var cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@pangkat", pangkat);
                cmd.Parameters.AddWithValue("@gelombangId", gelombangID);
                dt = GetDataTable(cmd);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

            return dt;
        }

        public DataTable GetDataTableGelombang(string pangkat)
        {
            DataTable dt;

            try
            {
                string query;
                query = string.Format("SELECT GelombangID,TahunPendaftaran FROM M_Gelombang WHERE Pangkat=@pangkat AND IsActive='1' ORDERBY GelombangID DESC");
                var cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@pangkat", pangkat);
                dt = GetDataTable(cmd);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

            return dt;
        }

        public string GetStringPanduan(string pangkat)
        {
            string fileName;

            try
            {
                string query = string.Format("SELECT Panduan FROM M_Info WHERE Pangkat=@pangkat");
                var cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@pangkat", pangkat);
                fileName = Convert.ToString(ExecuteScalar(cmd));
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

            return fileName;
        }
    }
}
