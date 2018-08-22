using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RobotSendSMSDynamic.api;
using RobotSendSMSDynamic.model;
using RobotSendSMSDynamic.utils;
using System.IO;

namespace RobotSendSMSDynamic.controller
{
    class ControllerObtainData
    {
        
        public static List<UserDateProgrammingPojo> excelData;

        public static void createJSONFile()
        {

            excelData = ReadGoogleSheetAPI.getDataFromGoogleSheetAPI();
            
            if (excelData != null)
            {
                List<String> sundayList = new List<String>();
                List<VideoproiectiePojo> programareVideoProiectiePojo = new List<VideoproiectiePojo>();
                foreach (UserDateProgrammingPojo currentRegistration in excelData)
                {



                    String day = DateUtil.formatDay(currentRegistration.Date);
                    String username = currentRegistration.Username;

                    if (day != null && day != "" && day != "-" && username != null && username != " " && username != "")
                    {

                        String phoneNumber = PhoneNumberUtil.getPhoneNumberForSpecificUser(username);
                        String dateProgramming = DateUtil.composeDate(DateUtil.getCurrentMonthMM(), day, DateUtil.getCurrentYearYYYY());
                        String sunday_morning = "";
                        String sunday_evening = "";
                        Console.WriteLine("dayyyy=" + day);

                        Console.WriteLine("phoneNumber=" + phoneNumber);


                        if (DateUtil.checkSunday(dateProgramming))
                        {

                            if (!sundayList.Contains(day))
                            {

                                sundayList.Add(day);
                                sunday_morning = "yes";
                                sunday_evening = "no";
                            }
                            else
                            {
                                sunday_morning = "no";
                                sunday_evening = "yes";
                            }
                        }
                        else
                        {
                            sunday_morning = "no";
                            sunday_evening = "no";
                        }

                        programareVideoProiectiePojo.Add(new VideoproiectiePojo(username, phoneNumber, dateProgramming, sunday_morning, sunday_evening));

                        Console.WriteLine("sundayMorning=" + sunday_morning);
                        Console.WriteLine("sundayEvening=" + sunday_evening);
                        Console.WriteLine("valoareeee=" + dateProgramming);
                    }

                }

                serializeObjectListToJSON(programareVideoProiectiePojo);

            }

        }




        public static void serializeObjectListToJSON(List<VideoproiectiePojo> listPojo)
        {
            StringBuilder sb = new StringBuilder();
            JsonWriter jw = new JsonTextWriter(new StringWriter(sb));

            jw.Formatting = Formatting.Indented;

            jw.WriteStartArray();
            foreach (VideoproiectiePojo currentPojo in listPojo)
            {

                jw.WriteStartObject();
                jw.WritePropertyName("username");
                jw.WriteValue(currentPojo.Username);

                jw.WritePropertyName("phoneNumber");
                jw.WriteValue(currentPojo.PhoneNumber);


                jw.WritePropertyName("dateProgramming");
                jw.WriteValue(currentPojo.DateProgramming);

                jw.WritePropertyName("sunday_morning");
                jw.WriteValue(currentPojo.Sunday_morning);


                jw.WritePropertyName("sunday_evening");
                jw.WriteValue(currentPojo.Sunday_evening);

                jw.WriteEndObject();

            }


            jw.WriteEndArray();

            System.IO.File.WriteAllText(FileUtil.filePathJSONProgramming, sb.ToString());


        }
    }


    
}
