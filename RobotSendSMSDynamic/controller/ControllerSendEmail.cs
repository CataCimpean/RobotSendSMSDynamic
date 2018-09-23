using RobotSendSMSDynamic.json;
using RobotSendSMSDynamic.model;
using RobotSendSMSDynamic.utils;
using RobotSendSMSDynamic.utils.email;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSendSMSDynamic.controller
{
    class ControllerSendEmail
    {

        public static void BuildEmail()
        {
            CheckDir();


            if (!CheckIfEmailWasSent())
            {
                Int64 currentDayAsInt = DateUtil.ParseDateTimeToIntDay(DateTime.Now);
                if (currentDayAsInt >= 28)
                {
                    LogMessage.PrintEventMessage("Emailurile au fost trimise cu succes");
                    SendEmail();
                }
                else
                {
                    LogMessage.PrintEventMessage("Emailurile nu au fost trimise inca");
                }
            }
        }

        private static void SendEmail()
        {
            List<UserEmailPojo> listEmail = ReadJSON.GetListEmail(FileUtil.fileEmailJSONPath);
            StringBuilder logFile = new StringBuilder();
            logFile.Append("*******Start SendEmail*******");
            logFile.AppendLine();
            foreach (UserEmailPojo currentUser in listEmail)
            {
                String username = currentUser.Username;
                String email = currentUser.Email;


                Boolean emailSent = EmailUtil.SendEmailToUsers(GetComposedMessage(username), email, "New Planning for " + DateUtil.getNextMonthEnglishLanguage());
                if (emailSent)
                {
                    logFile.AppendLine();
                    logFile.Append("Username= " + currentUser.Username);
                    logFile.AppendLine();
                    logFile.Append("Email= " + currentUser.Email);
                    logFile.AppendLine();
                    logFile.Append("Date= " + DateTime.Now);
                    logFile.AppendLine();
                }

            }

            logFile.AppendLine();
            logFile.Append("*******End SendEmail*******");

            using (StreamWriter file = new StreamWriter(FileUtil.logFile, false))
            {
                file.WriteLine(logFile.ToString());
            }
        }

        private static String GetComposedMessage(String username)
        {
            StringBuilder message = new StringBuilder();
            message.Append("Salut," +"<b>" +username+" </b> echipa Videoproiectie Speranta iti este recunoscatoare pentru implicarea ta." );
            message.Append("Pentru o mai buna organizare, te rugam sa adaugi planificarea ta pentru luna urmatoare.");
            
            return message.ToString();
        }

        private static void createFile()
        {
            File.Create(FileUtil.logFile);
        }

        private static Boolean CheckIfEmailWasSent()
        {
            Boolean sent = false;
            if (File.Exists(FileUtil.logFile))
            {
                sent = true;
            }

            return sent;
        }

        private static void CheckDir()
        {
            if(!Directory.Exists(FileUtil.logDirectory))
            System.IO.Directory.CreateDirectory(FileUtil.logDirectory);
        }

    }
}
