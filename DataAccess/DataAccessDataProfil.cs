using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using System.Data.SqlClient;

namespace DataAccess
{
    public class DataAccessDataProfil : DataAccessMain
    {
        public DataTable GetDataTableParameter(string parameterType, string pangkat)
        {
            DataTable dt;

            try
            {
                dt = GetDataTable(string.Format("SELECT ParameterID,ParameterName FROM M_Parameter WHERE ParameterType ='{0}'AND (pangkat like '%{0}%' OR pangkat = 'all') ORDER BY ParameterID", parameterType, pangkat));
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

            return dt;
        }

        public DataTable GetDataTableParameter(string parameterType, string pangkat, int ParameterID)
        {
            DataTable dt;

            try
            {
                dt = GetDataTable(string.Format("SELECT ParameterID,ParameterName FROM M_Parameter WHERE ParameterType ='{0}' AND AND (pangkat like '%{0}%' OR pangkat = 'all') AND ParameterID={2} ORDER BY ParameterID", parameterType, pangkat, ParameterID));
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }

        public DataTable GetDataTablePanda(string WilayahID)
        {
            DataTable dt;

            try
            {
                dt = GetDataTable(string.Format("SELECT WilayahName FROM M_Panda WHERE WilayahId = '{0}'", WilayahID));
            }
            catch (Exception)
            {
                
                throw;
            }

            return dt;
        }

        public DataTable getDataTable_DataProfil_byEmail(string email,string panda)
        {
            DataTable dt;
            try
            {
                string sql = "SELECT a.*,b.Pangkat,b.PandaId,b.NoAnimo FROM M_Pendaftar_Profile a INNER JOIN M_Pendaftar b on a.useremail=b.email WHERE a.UserEmail =@email";
                string whereField = string.Format(" AND b.pandaId='{0}'", panda);

                if (panda != null)
                    if (panda != "")
                        sql += whereField;

                SqlParameter param = new SqlParameter("@email", email);
                
                dt = GetDataTable(sql,new SqlParameter[] { param });
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }
        public DataTable getDataTable_DataProfil_byNoAnimo(string noAnimo)
        {
            DataTable dt;
            try
            {
                string sql = string.Format("SELECT a.*,b.Pangkat,b.PandaId FROM M_Pendaftar_Profile a INNER JOIN M_Pendaftar b on a.useremail=b.email WHERE b.NoAnimo ='{0}'", noAnimo);
                dt = GetDataTable(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }
        public decimal getMinTinggiBadan(char jenisKelamin)
        {
            try
            {
                string query = string.Format("SELECT SettingValue FROM M_Settings WHERE SettingName = 'MinHeight' AND SettingParameter = '{0}'", jenisKelamin);
                return Convert.ToDecimal(ExecuteScalar(query));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public string getEmailPendaftar(string noAnimo)
        {
            try
            {
                string query = string.Format("SELECT Email FROM M_Pendaftar WHERE NoAnimo = '{0}'", noAnimo);
                return Convert.ToString(ExecuteScalar(query));
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void DataUpdate(DataStruct.DataStructDataProfil args)
        {
            try
            {
                dbLinq.usp_Pendaftar_Profile_Insert(args.email,
                    "",
                    args.Nama, 
                    args.TinggiBadan, 
                    args.BeratBadan, 
                    args.JenisKelamin, 
                    args.TempatLahir, 
                    args.TanggalLahir, 
                    args.Agama, 
                    args.Suku, 
                    args.Alamat, 
                    args.Kabupaten, 
                    args.Propinsi, 
                    args.Telp, 
                    args.NoKTP, 
                    args.StatusSD ,
                    args.NamaSD, 
                    args.KotaAsalSD, 
                    args.PropinsiSD,
                    args.TahunLulusSD,
                    args.NEMSD,
                    args.StatusSMP, 
                    args.NamaSMP, 
                    args.KotaAsalSMP, 
                    args.PropinsiSMP, 
                    args.TahunLulusSMP, 
                    args.NEMSMP, 
                    args.StatusSMA,
                    args.NamaSMA, 
                    args.KotaAsalSMA, 
                    args.PropinsiSMA, 
                    args.TahunLulusSMA,
                    args.NEMSMA, 
                    args.NilaiUN, 
                    args.Pendidikan, 
                    args.Jurusan, 
                    args.NamaBpk,
                    args.AlamatBpk, 
                    args.PekerjaanBpk, 
                    args.JabatanBpk, 
                    args.NamaKantorBpk, 
                    args.NamaIbu,
                    args.AlamatIbu, 
                    args.PekerjaanIbu, 
                    args.JabatanIbu, 
                    args.NamaKantorIbu,
                    args.NamaWali,
                    args.AlamatWali, 
                    args.PekerjaanWali, 
                    args.JabatanWali, 
                    args.NamaKantorWali, 
                    args.PendaftaranKe, 
                    args.PendaftaranDari, 
                    args.Prestasi1, 
                    args.JuaraKe1, 
                    args.Tingkatan1, 
                    args.Prestasi1, 
                    args.JuaraKe2, 
                    args.Tingkatan2, 
                    args.Prestasi3, 
                    args.JuaraKe3, 
                    args.Tingkatan3, 
                    args.ModifiedBy);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        public void AddPeserta(string noAnimo, string modifiedBy)
        {
            try
            {
                dbLinq.usp_M_Pendaftar_AddPesertaRev(noAnimo, modifiedBy);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
