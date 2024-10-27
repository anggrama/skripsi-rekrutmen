using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DataAccessDashboardUser:DataAccessBase
    {
        public DataTable getDataTable_Riwayat(string email)
        {
            string sql = "SELECT * FROM vRegistrationHistory WHERE UserEmail=@email ORDER BY NoPeserta DESC";
            try
            {
                var cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@email", email);
                return GetDataTable(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable getDataTable_NilaiPeserta(string noPeserta)
        {
            string sql = "SELECT b.keterangan,CASE WHEN a.IsLulus=1 THEN 'LULUS' ELSE 'GAGAL' END 'Hasil' FROM dbo.M_Nilai a INNER JOIN m_tipeNilai b ON a.TipeNilai = b.tipeNilai WHERE a.NoPeserta=@noPeserta ORDER BY b.Urutan";
            try
            {
                var cmd = new SqlCommand(sql);
                cmd.Parameters.AddWithValue("@noPeserta", noPeserta);
                return GetDataTable(cmd);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
