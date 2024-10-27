using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataStruct;

namespace DataAccess
{
    public class DataAccessDaftar : DataAccessMain
    {

        public string InsertDaftar(DataStructDaftar args)
        {
            string noAnimo = "";
            try
            {
                dbLinq.usp_M_Pendaftar_INSERTRev(ref noAnimo,args.GelombangID, args.TahunPendaftaran, args.Email, args.Nama ,args.Pendidikan, args.NamaSekolah,args.KotaAsalSMA,args.PropinsiSMA, args.TahunLulusSMA, args.TanggalLahir, args.TempatLahir, args.NoKTP, args.Wilayah, args.Pangkat,args.JenisKelamin,args.Alamat,args.Kota,args.Propinsi,args.NoTelepon,args.Agama,args.Suku,args.TinggiBadan,args.BeratBadan);
            }
            catch (Exception)
            {
                throw;
            }

            return noAnimo;
        }

        public bool EmailValidate(string email, string gelombangId, string pandaId)
        {
            try
            {
                string query = "SELECT COUNT(1) FROM M_Pendaftar WHERE Email = @email AND GelombangID = @gelombangId AND PandaId = @pandaId";
                var cmd = new System.Data.SqlClient.SqlCommand(query);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@gelombangId", gelombangId);
                cmd.Parameters.AddWithValue("@pandaId", pandaId);
                return Convert.ToBoolean(ExecuteScalar(cmd));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool getEmailExists(string email)
        {
            try
            {
                string query = "SELECT COUNT(1) FROM M_Pendaftar_Profile WHERE UserEmail = @email";
                var cmd = new System.Data.SqlClient.SqlCommand(query);
                cmd.Parameters.AddWithValue("@email", email);
                return Convert.ToBoolean(ExecuteScalar(cmd));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool IsValidWilayah(string wilayahId)
        {
            try
            {
                string query = "SELECT COUNT(1) FROM M_Panda WHERE WilayahId = @wilayahId";
                var cmd = new System.Data.SqlClient.SqlCommand(query);
                cmd.Parameters.AddWithValue("@wilayahId", wilayahId);
                return Convert.ToBoolean(ExecuteScalar(cmd));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
