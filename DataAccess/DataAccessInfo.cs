using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DataAccessInfo : DataAccessBase
    {
        //public string getDataTable_Settings(string pangkat)
        //{
        //    string sql = string.Format("SELECT * FROM M_Settings WHERE SettingParameter = '{0}'", pangkat);

        //    try
        //    {
        //       return Convert.ToString(ExecuteScalar(sql));
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        public string getValue_Settings(string settingParameter, string settingName)
        {
            string sql = string.Format("SELECT SettingValue FROM M_Settings WHERE SettingName='{0}' AND SettingParameter = '{1}'", settingName, settingParameter);
            try
            {
                return Convert.ToString(ExecuteScalar(sql));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string getValue_Password (string email)
        {
            string sql = "SELECT Pass FROM dbo.M_Pendaftar_Profile WHERE UserEmail=@userEmail";
            SqlParameter param = new SqlParameter("@userEmail", email);
            
            try
            {
                return Convert.ToString(ExecuteScalar(sql,new SqlParameter[] {param}));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable getDataTable_Inbox(string pandaId)
        {

            string toPanda;
            if (pandaId == "")
                toPanda = "IS NULL";
            else
                toPanda = string.Format("='{0}'", pandaId);

                string sql = string.Format("SELECT Id,InfoId,Judul,FromPanda,CreatedBy,CreatedDate FROM vInfo_Lanud_Inbox WHERE ToPanda {0} ORDER BY CreatedDate DESC", toPanda);
            try
            {
                return GetDataTable(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable getDataTable_Outbox(string pandaId)
        {
            string fromPanda;
            if (pandaId == "")
                fromPanda = "IS NULL";
            else
                fromPanda = string.Format("='{0}'", pandaId);

            string sql = "SELECT * FROM vInfo_Lanud_Outbox WHERE FromPanda " + fromPanda;
            try
            {
                return GetDataTable(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable getDataTable_Panda()
        {
            string sql = "SELECT WilayahId,WilayahName FROM M_Panda WHERE isActive=1";
            try
            {
                return GetDataTable(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int getInt_UnreadMessage(string pandaId)
        {
            string sql = string.Format("SELECT COUNT(1) FROM dbo.M_Info_Pesan_Panda WHERE ToPanda='{0}' AND IsRead=0",pandaId);
                try
                {
                    return Convert.ToInt32(ExecuteScalar(sql));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
        }
        public DataTable getDataTable_ReadMessage(string infoId,string panda,string readType)
        {
            string whereTemplate = "";
            string whereString = "";
            //if (readType == "out")
            //{
            //    whereField = "FromPanda IS NULL";
            //    panda = null;
            //}

            //if (panda == "")
            //    panda = null;

            if (readType == "out")
                whereTemplate = "FromPanda";
            else
                whereTemplate = "ToPanda";

            if (panda == "")
                whereString = whereTemplate + " IS NULL";
            else
                whereString = whereTemplate + string.Format("='{0}'", panda);


            string sql = "SELECT TOP(1) * FROM vInfo_Lanud WHERE InfoId=@infoId AND " + whereString;
            SqlParameter param1 = new SqlParameter("@infoId", infoId);
            try
            {
                return GetDataTable(sql, new SqlParameter[] { param1 });
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable getDataTable_ReadFiles(string infoId)
        {

            string sql = "SELECT CaptionName,FilePath FROM M_Info_Pesan_File WHERE InfoId=@infoId";
            SqlParameter param1 = new SqlParameter("@infoId", infoId);
            try
            {
                return GetDataTable(sql, new SqlParameter[] { param1 });
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void delete_Message_Outbox(string infoId)
        {
            string sql = string.Format("UPDATE M_Info_Pesan SET DeletedDate=GETDATE() WHERE InfoId='{0}'",infoId);
            try
            {
                ExecuteQuery(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void delete_Message_Inbox(string Id)
        {
            string sql = string.Format("UPDATE M_Info_Pesan_Panda SET DeletedDate=GETDATE() WHERE Id='{0}'", Id);
            try
            {
                ExecuteQuery(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

    
    }
    
}
