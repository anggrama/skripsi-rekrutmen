using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DataAccess
{
    public class DataAccessDataAnimo : DataAccessMain
    {


        string sqlDefault = "SELECT a.NoAnimo,a.NoPeserta,b.Nama,ISNULL(b.TinggiBadan,0) AS TinggiBadan,ISNULL(b.BeratBadan,0) AS BeratBadan,ISNULL(b.TahunLulusSMA,0) AS TahunLulus,b.NilaiUN FROM M_Pendaftar a INNER JOIN M_Pendaftar_Profile b ON a.email = b.useremail ";
        public DataTable getDataTable_Animo(string pandaId, string pangkat, string gelombangKe, string tahun)
        {
            DataTable dt;

            try
            {
                string sql = sqlDefault + string.Format(" WHERE a.PandaId like '{0}%' AND a.Pangkat='{1}' AND a.GelombangID = '{2}' and a.TahunPendaftaran='{3}' ORDER BY a.PandaId,b.JenisKelamin,a.NoAnimo", pandaId, pangkat, gelombangKe,tahun);
                dt = GetDataTable(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        public DataTable getDataTable_Peserta(string pandaId, string pangkat, string gelombangKe, string tahun)
        {
            DataTable dt;

            try
            {
                string sql = sqlDefault + string.Format(" WHERE NoPeserta IS NOT NULL AND  a.PandaId like '{0}%' AND  a.Pangkat like '{1}' AND a.GelombangID = '{2}' and a.TahunPendaftaran='{3}'  ORDER BY a.PandaId,b.JenisKelamin,a.NoPeserta", pandaId, pangkat, gelombangKe,tahun);
                dt = GetDataTable(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }

        public DataTable getDataTable_DataPendaftar(string panda, string gelombangKe, string pangkat, bool isPeserta,string tahun)
        {

            string sql = string.Format("SELECT * FROM vPendaftar WHERE PandaId like '{0}%' AND GelombangID={1} AND Pangkat='{2}' AND TahunPendaftaran='{3}'", panda, gelombangKe, pangkat,tahun);
            if (isPeserta == true)
                sql += " AND NoPeserta IS NOT NULL";

            sql += " ORDER BY PandaId,NoPeserta";
            try
            {
                return GetDataTable(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
