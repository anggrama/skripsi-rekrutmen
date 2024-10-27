using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraReports.UI;
using DevExpress.DataAccess.Sql;

namespace RekrutmenTNI
{
    class reportAdapter : XtraReportBase
    {
        private XtraReport rpt;
        private string _path;

        public reportAdapter(string path)
        {
            rpt = new XtraReport();
            _path = path;
        }
        protected reportAdapter()
        {
            
        }

        private void SetConnectionString()
        {
            try
            {
                var datasource = (SqlDataSource)rpt.DataSource;
                string cnstr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ToString();
                datasource.Connection.ConnectionString = cnstr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public XtraReport getRptPendaftaran(string noAnimo)
        {
            try
            {
                rpt = XtraReport.FromFile(_path + "\\Report\\rptPendaftaran.repx", true);
                rpt.Parameters["noAnimo"].Value = noAnimo;
                SetConnectionString();
                return rpt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public XtraReport getRptSurat(string noAnimo)
        {
            try
            {
                rpt = XtraReport.FromFile(_path + "\\Report\\rptSurat.repx", true);
                rpt.Parameters["noAnimo"].Value = noAnimo;
                SetConnectionString();
                return rpt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public XtraReport getTestReport()
        {
            try
            {
                rpt = XtraReport.FromFile(_path + "\\Report\\rptTest.repx", true);
                return rpt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
