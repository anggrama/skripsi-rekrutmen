using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using System.Net;
using System.Net.Mail;

using System.Configuration;

namespace RekrutmenTNI
{
    public class MailClass
    {
        private string _SmtpPort;
        private string _smtpServer;
        private string _email;
        private string _userId;
        private string _password;

        public MailClass()
        {
            _SmtpPort = ConfigurationManager.AppSettings["smtp_Port"];
            _smtpServer = ConfigurationManager.AppSettings["smtp_Server"];
            _userId = ConfigurationManager.AppSettings["smtp_User"];
            _password = ConfigurationManager.AppSettings["smtp_Pass"];
            _email = ConfigurationManager.AppSettings["smtp_Email"];
        }

        //private void SendEmailMessage(string strTo, string strSubject, string strMessage)
        //{
        //    //This procedure overrides the first procedure and accepts a single
        //    //string for the recipient and file attachement 
        //    string userState = "-";
        //    try
        //    {

        //        MimeMailMessage mess = new MimeMailMessage();

        //        MimeMailer mailer = new MimeMailer(_smtpServer, Convert.ToInt32(_SmtpPort), _userId, _password, SslMode.Ssl, AuthenticationType.Base64);
        //        mailer.EnableImplicitSsl = true;
        //        mailer.Send(_email, strTo, strSubject, strMessage);

        //    }
        //    catch (Exception ex)
        //    {
        //        //throw new Exception(string.Format("Error : {0}{1}Status : {2}", ex.Message, Environment.NewLine, userState));
        //        //Throw New Exception("Status : " & userState)
        //        throw;
        //    }
        //}

        private void SendEmailMessageSMTP(string strTo, string strSubject, string strMessage)
        {
            //This procedure overrides the first procedure and accepts a single
            //string for the recipient and file attachement 
            string userState = "-";
            try
            {
                MailMessage mess = new MailMessage(_email, strTo, strSubject, strMessage);
                mess.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient(_smtpServer, Convert.ToInt32(_SmtpPort));
                smtp.Credentials = new NetworkCredential(_email,_password);
                smtp.Send(mess);
                    
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void SendEmail_ForgotEmail(string strTo)
        {
            try
            {
                using (DataAccess.DataAccessInfo oDa = new DataAccess.DataAccessInfo())
                {
                    string pass = oDa.getValue_Password(strTo);
                    if (pass == "")
                        throw new Exception("email anda tidak ada di database kami.");

                    string content = oDa.getValue_Settings("Forget", "Email");
                    string sContent = string.Format(content, strTo, pass);
                    SendEmailMessageSMTP(strTo, "Lupa Password", sContent);
                }
                    
            }
            catch (Exception)
            {
                throw;
            }
            
        }

    }
}
