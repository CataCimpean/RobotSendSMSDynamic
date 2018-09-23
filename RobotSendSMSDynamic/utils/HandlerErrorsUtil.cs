using RobotSendSMSDynamic.utils.email;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSendSMSDynamic.utils
{
    class HandlerErrorsUtil
    {
        
        public static void handlerWarningFromFileJSON(int type)
        {

            if (type == 1)
            {
                String messageEx = "Nu avem date de incarcat,va rugam actualizati fisierul JSON";
                LogMessage.PrintEventWarning(messageEx);
                EmailUtil.SendEmailToAdministrator(messageEx, "ExceptionSendSMSApp");

            }
            else if (type == 2) {
                if (!File.Exists(FileUtil.filePathJSONProgramming))
                {
                    String messageEx = "Nu a fost gasit fisierul JSON in locatie cu proiectul.Va rugam verificati!.";
                    LogMessage.PrintEventWarning(messageEx);
                    EmailUtil.SendEmailToAdministrator(messageEx, "ExceptionSendSMSApp");
                }
                else
                {
                    String messageEx = "Fisierul JSON este gol/null va rugam verificati continutul acestuia.";
                    LogMessage.PrintEventWarning(messageEx);
                    EmailUtil.SendEmailToAdministrator(messageEx, "ExceptionSendSMSApp");
                }
            }
        }


        public static void handlerErrorFromGoogleAPI(String message) {
            
            StringBuilder errorMessageToDisplay = new StringBuilder();
            errorMessageToDisplay.Append("A aparut o eroare la parsarea datelor din sheet(Google API).");

            if (message.Contains("Unable to parse range")){
                errorMessageToDisplay.Append("Verificati daca exista sheetul respectiv.");
                errorMessageToDisplay.AppendLine();
                errorMessageToDisplay.Append(message);
            }
            else
            {
                errorMessageToDisplay.Append(message);
            }

            EmailUtil.SendEmailToAdministrator(errorMessageToDisplay.ToString(), "ExceptionSendSMSApp");
            LogMessage.PrintEventError(errorMessageToDisplay.ToString());

        }

        public static void handlerErrorFromService(String errorMessage) {


            int errorCode = 0;
            string recivedStatus = "";
            if (errorMessage.Contains("\"code\":3"))
            {
                recivedStatus = "Invalid_Number";
                errorCode = 3;
            }
            else if (errorMessage.Contains("\"code\":6"))
            {
                recivedStatus = "Message_too_long";
                errorCode = 6;
            }
            else if (errorMessage.Contains("\"code\":7"))
            {
                recivedStatus = "Insufficient_Credits";
                errorCode = 7;
            }

            displayErrorFromService(recivedStatus, errorCode);

        }

        public static void displayErrorFromService(String recivedStatusFromService, int errorCode)
        {
            String messageError = "A aparut o eroare la trimiterea SMS-ului in data de "
                              + DateUtil.GetTodayAsString() + " Denumire eroare: " + recivedStatusFromService + " Cod eroare: " + errorCode + " ."
                              + "Pt mai multe detalii consultati siteul https://api.txtlocal.com/docs/sendsms ";
            LogMessage.PrintEventError(messageError);
            EmailUtil.SendEmailToAdministrator(messageError, "ErrorSendSMSApi");
        }
    }

    
}
