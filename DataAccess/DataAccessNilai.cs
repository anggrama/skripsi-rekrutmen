using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DataAccessNilai :DataAccessBase
    {
        public DataTable getDataTable_Peserta(string pandaId, string gelombangId, string pangkat,string tipeNilai)
        {
            try
            {
                string nilaiAll = "";
                string nilaiPilih = "1";
                if (tipeNilai != "All")
                {
                    nilaiAll = string.Format("{0} IS NOT NULL AND  ", tipeNilai);
                    nilaiPilih = tipeNilai;
                }
                string sql = string.Format("SELECT *,{4} AS Pilih FROM  vData_Nilai WHERE {3} GelombangID='{0}' AND pangkat='{1}' AND pandaid='{2}'", gelombangId, pangkat, pandaId,nilaiAll,nilaiPilih);
                return GetDataTable(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable getDataTable_Peserta_Pusat(string gelombangId, string pangkat, string tipeNilai)
        {
            try
            {
                string nilaiAll = "";
                string nilaiPilih = "1";
                if (tipeNilai != "All")
                {
                    nilaiAll = string.Format("{0} IS NOT NULL AND", tipeNilai);
                    nilaiPilih = tipeNilai;
                }
                string sql = string.Format("SELECT *,{3} AS Pilih FROM vData_Nilai WHERE {2} GelombangID='{0}' AND pangkat='{1}' AND Pantukhirda = 'LLS'", gelombangId, pangkat,nilaiAll,nilaiPilih);
                return GetDataTable(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void SaveNilai(DataTable dtData,string uploadType)
        {
           SqlTransaction oTrx = null;
            try
            {
                oCn.Open();
                oTrx = oCn.BeginTransaction();
                dbLinq.Transaction = oTrx;

                if (dtData.Columns.Contains("NoPesertaPusat"))
                {
                    foreach (DataRow row in dtData.Rows)
                    {
                        dbLinq.usp_Insert_NilaiByPesertaPusat(row["NoPesertaPusat"].ToString(),
                            Convert.ToDouble(row["NilaiAngka"]),
                            row["NilaiHuruf"].ToString(),
                            row["Status"].ToString(),
                            row["Keterangan"].ToString(),
                            uploadType);
                    }
                }
                else
                {
                    foreach (DataRow row in dtData.Rows)
                    {
                        dbLinq.usp_Insert_Nilai(row["NoPeserta"].ToString(),
                            Convert.ToDouble(row["NilaiAngka"]),
                            row["NilaiHuruf"].ToString(),
                            row["Status"].ToString(),
                            row["Keterangan"].ToString(),
                            uploadType);
                    }
                }

                
             

                oTrx.Commit();
            }
            catch (Exception ex)
            {
                if (oTrx != null)
                    oTrx.Rollback();

                throw ex;
            }
            finally
            {
                oCn.Close();
            }
        }
        public DataTable getDataTable_ParameterNilai(string tipeNilai)
        {
            string sql = string.Format("SELECT ParameterId,ParameterName FROM M_Parameter WHERE ParameterType='{0}' ORDER BY ParameterName",tipeNilai);
            try
            {
                return GetDataTable(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void UpdateNoPesertaPusat(DataTable dtData)
        {
            string sql = "UPDATE M_Pendaftar SET NoPesertaPusat=@NoPesertaPusat WHERE NoPeserta=@NoPeserta";
            try
            {
                foreach (DataRow row in dtData.Rows)
                {
                    SqlParameter paramNoPesertaPusat = new SqlParameter("@NoPeserta", row["NoPeserta"]);
                    SqlParameter paramNoPeserta = new SqlParameter("@NoPesertaPusat", row["NoPesertaPusat"]);

                    ExecuteQuery(sql, new SqlParameter[] { paramNoPesertaPusat, paramNoPeserta });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
