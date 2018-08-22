using RobotSendSMSDynamic.model;
using RobotSendSMSDynamic.utils;
using RobotSendSMSDynamic.utils.email;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RobotSendSMSDynamic.api
{
    class SendSmsAPI
    {

        public static String SendSMSToRecipient(VideoproiectiePojo recipient)
        {

            String result = "";
            using (var wb = new WebClient())
            {
                String messageToSend = getSMSContent(recipient);
                String number = String.Concat("4", recipient.PhoneNumber);
                String encoddedMessageToSend = WebUtility.UrlEncode(messageToSend);

                Console.WriteLine("numbeeeer=" + number);
                if (messageToSend != "")
                {
                    byte[] response = wb.UploadValues("http://api.txtlocal.com/send/", new NameValueCollection()    
                   {  

                       {"username","catacimpean@yahoo.com"},   
                       {"hash" , "4858c69848bb3692ebb91f946f6466b1948d53eba2f53376ba42992f28e51850"},   // find in your account txtLocal->Help->AllDocumentation
                       {"numbers" ,  number},            
                       {"message" , encoddedMessageToSend},            
                       {"sender" , "VP"}         
                   });

                    result = System.Text.Encoding.UTF8.GetString(response);

                    Console.WriteLine(result);
                }

            }

            return result;

        }

        public static String getSMSContent(VideoproiectiePojo recipient)
        {

            if (recipient != null)
            {

                string message = "Buna ";
                message = String.Concat(message, recipient.Username);

                if (recipient.DateProgramming.Equals(DateUtil.GetTomorrowAsString()))
                {
                    string sunday_morning = recipient.Sunday_morning;
                    string y = "yes";
                    string n = "no";
                    if (sunday_morning.ToLower().Equals(y.ToLower()))
                    {
                        message = String.Concat(message, ", iti reamintim ca maine dimineata " + DateUtil.GetTomorrowAsString() + " esti la proiectie.Multumim de implicare, echipa VideoProiectie Speranta.");
                    }
                    else if (sunday_morning.ToLower().Equals(n.ToLower()))
                    {
                        message = String.Concat(message, ", iti reamintim ca maine dupamasa " + DateUtil.GetTomorrowAsString() + " esti la proiectie.Multumim de implicare, echipa VideoProiectie Speranta.");
                    }

                }
                else if (recipient.DateProgramming.Equals(DateUtil.GetTodayAsString()))
                {
                    message = String.Concat(message, ", iti reamintim ca astazi " + DateUtil.GetTodayAsString() + " esti la proiectie.Multumim de implicare, echipa VideoProiectie Speranta.");
                }

                return message;
            }
            return "";
        }

    }
}
