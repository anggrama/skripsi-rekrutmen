using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataAccess
{
    public class DataAccessPengaturan : DataAccessMain
    {
        //public DataTable GetDataTableHtml(string pangkat)
        //{
        //    DataTable dt;
        //    string query;

        //    try
        //    { 
        //        query = string.Format("SELECT * FROM M_Info WHERE Pangkat = '{0}'",pangkat);
        //        dt = GetDataTable(query);
        //    }
        //    catch (Exception ex)
        //    {
                
        //        throw ex;
        //    }

        //    return dt;
        //}

        public DataTable GetDataTableHtml(string pangkat)
        {
            DataTable dt;
            string query;

            try
            {
                query = string.Format("SELECT * FROM M_Settings WHERE SettingParameter = '{0}'", pangkat);
                dt = GetDataTable(query);
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
            string query;

            try
            {
                query = string.Format("SELECT * FROM M_InfoLulus WHERE Pangkat = '{0}'", pangkat);
                dt = GetDataTable(query);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }
        public void UpdatePanduan(DataStruct.DataStructPengaturan args)
        {
            try
            {
                dbLinq.usp_M_Info_UpdatePanduan(args.Pangkat, args.Panduan);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        public void Save(DataStruct.DataStructPengaturan args)
        {
            try
            {
                dbLinq.usp_M_Info_Save(args.Pangkat, args.Pengumuman, args.Persyaratan, args.Lokasi, args.Jadwal, args.MateriSeleksi, false, false, "", 0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SaveMinHeight(float laki, float perempuan)
        {
            try
            {
                dbLinq.usp_M_Setting_Save(laki.ToString(), perempuan.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
