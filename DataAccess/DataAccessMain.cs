﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DataAccessMain : DataAccessBase
    {
        public DataTable getDataTable_TahunPendaftaran(string pangkat)
        {
            DataTable dt;

            try
            {
                string query = string.Format("SELECT DISTINCT TahunPendaftaran FROM M_Gelombang WHERE Pangkat like @pangkat AND IsActive = 1 ORDER BY TahunPendaftaran DESC");
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
        public DataTable getDataTable_Gelombang(string tahunPendaftaran, string pangkat)
        {
            DataTable dt;

            try
            {
                string query = string.Format("SELECT GelombangID,GelombangKe FROM M_Gelombang WHERE TahunPendaftaran = @tahunPendaftaran AND Pangkat like @pangkat AND IsActive = 1 ORDER BY GelombangKe DESC");
                var cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@tahunPendaftaran", tahunPendaftaran);
                cmd.Parameters.AddWithValue("@pangkat", pangkat);
                dt = GetDataTable(cmd);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }
        public DataTable getDataTable_GelombangAktif(string pangkat)
        {
            DataTable dt;

            try
            {
                string query = string.Format("SELECT GelombangID,GelombangKe,TahunPendaftaran FROM M_Gelombang WHERE RangeFrom <= CAST(GETDATE() as date) AND RangeTo >= CAST(GETDATE() as date) AND Pangkat like @pangkat");
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
        public DataTable getDataTable_Pendidikan(string pangkat)
        {
            DataTable dt;

            try
            {
                string query = string.Format("SELECT ParameterID,ParameterName FROM M_Parameter WHERE ParameterType = 'Pendidikan' AND (pangkat like '%{0}%' OR pangkat = 'all')", pangkat);
                dt = GetDataTable(query);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }
        public DataTable getDataTable_Wilayah(string pangkat,string jenisKelamin)
        {
            DataTable dt;

            try
            {
                string sql = string.Format("SELECT WilayahId,WilayahName FROM M_Panda WHERE (pangkat_JK like '%{0}-{1}%' OR pangkat_JK = 'all')", pangkat, jenisKelamin);
                dt = GetDataTable(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }
        public DataTable getDataTable_JenisKelamin(string pangkat)
        {
            DataTable dt;

            try
            {
                string sql = string.Format("SELECT ParameterID,ParameterName FROM M_Parameter WHERE ParameterType = 'JK' AND (pangkat like '%{0}%' OR pangkat = 'all')", pangkat);
                dt = GetDataTable(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }

        public DataTable getDataTable_MinMaxDate(int gelombangId)
        {
            DataTable dt;

            try
            {
                string query = string.Format("SELECT BornFrom,BornTo FROM M_Gelombang WHERE GelombangID=@gelombangId");
                var cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@gelombangId", gelombangId);
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
