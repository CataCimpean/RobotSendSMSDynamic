using RobotSendSMSDynamic.api;
using RobotSendSMSDynamic.json;
using RobotSendSMSDynamic.model;
using RobotSendSMSDynamic.utils;
using RobotSendSMSDynamic.utils.email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSendSMSDynamic.controller
{
    class ControllerSendSMS
    {


        private static List<VideoproiectiePojo> listOfRecipients = null;

        public static void startSendSMS()
        {
    

            listOfRecipients = ReadJSON.getListProgramming(FileUtil.filePathJSONProgramming);

            if (listOfRecipients != null)
            {

                if (listOfRecipients != null && listOfRecipients.Count != 0)
                {
                    foreach (VideoproiectiePojo currentRecipient in listOfRecipients)
                    {

                        String serviceResponse = SendSmsAPI.SendSMSToRecipient(currentRecipient);
                        //mesaje in eventViewer de succes respectiv eroare.
                        if (serviceResponse.Contains("\"status\":\"success\""))
                        {
                            String notification = "SMS trimis cu succes catre " + currentRecipient.Username + " la nr tel " +currentRecipient.PhoneNumber+  " " +" In data de " + DateTime.Now;
                            LogMessage.PrintEventMessage(notification); 
                            EmailUtil.sendEmail(notification, "Notification");
                        }
                        else
                        {
                            HandlerErrorsUtil.handlerErrorFromService(serviceResponse);
                        }
                    }
                }
                else
                {
                    HandlerErrorsUtil.handlerWarningFromFileJSON(1);
                }


            }
            else
            {
                HandlerErrorsUtil.handlerWarningFromFileJSON(2);
            }


        }


        internal List<VideoproiectiePojo> ListOfRecipients
        {
            get { return listOfRecipients; }
            set { listOfRecipients = value; }
        }

    }
}
