using RobotSendSMSDynamic.utils.decrypt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace RobotSendSMSDynamic.utils.email
{
    class EmailUtil
    {



        public static void sendEmail(String message, String subject)
        {

            try
            {

                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Port = 587;
                SmtpServer.EnableSsl = true;
                SmtpServer.Credentials = new System.Net.NetworkCredential("videoproiectiebscj@gmail.com", DecryptUtil.Decrypt("ZTLLdT2lYgXkuSRUtob7aw=="));


                //Specify the e-mail sender
                MailAddress from = new MailAddress("catacimpean@yahoo.com",
                "VideoproiectieBSCJ");

                string destinationEmail = "catacimpean@yahoo.com";
                MailAddress to = new MailAddress(destinationEmail);


                //Compose email
                MailMessage mailContent = new MailMessage(from, to);
                mailContent.Body = TemplateHTML.BuildHTMLTemplate("VideoproiectieBSCJ", message);
                mailContent.Subject = subject;
                mailContent.IsBodyHtml = true;

                //mailContent.CC.Add(carbonCopy);

            


                SmtpServer.Send(mailContent);
                SmtpServer.Dispose();
                mailContent.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }


        }



    }

}
