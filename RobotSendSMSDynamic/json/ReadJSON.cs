using Newtonsoft.Json;
using RobotSendSMSDynamic.model;
using RobotSendSMSDynamic.utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSendSMSDynamic.json
{
    class ReadJSON
    {

        public static List<PhoneNumberPojo> getPhoneNumberList(String filePathPhoneNumberJSON)
        {

            List<PhoneNumberPojo> list = null;

            using (StreamReader r = new StreamReader(filePathPhoneNumberJSON))
            {
                String json = r.ReadToEnd();
                var jsonAsString = JsonConvert.DeserializeObject<List<PhoneNumberPojo>>(json);

                if (jsonAsString != null)
                {
                    list = new List<PhoneNumberPojo>();

                    foreach (var current in jsonAsString)
                    {
                        list.Add(new PhoneNumberPojo(current.Username, current.PhoneNumber));
                    }
                }

            }
            return list;
        }


        public static List<VideoproiectiePojo> getListProgramming(String filePathVideoProiectieJSON)
        {

            List<VideoproiectiePojo> list = null;

            using (StreamReader r = new StreamReader(filePathVideoProiectieJSON))
            {
                String json = r.ReadToEnd();
                var jsonAsString = JsonConvert.DeserializeObject<List<VideoproiectiePojo>>(json);

                if (jsonAsString != null)
                {
                    list = new List<VideoproiectiePojo>();

                    foreach (var current in jsonAsString)
                    {

                        if (current.DateProgramming.Equals(DateUtil.GetTodayAsString()))
                        {
                            list.Add(current);
                        }
                        else if (current.DateProgramming.Equals(DateUtil.GetTomorrowAsString()))
                        {
                            DayOfWeek today = DateTime.Now.DayOfWeek;

                            if ((today == DayOfWeek.Saturday) || (today == DayOfWeek.Sunday))
                            {
                                list.Add(current);
                            }

                        }
                    }

                }
                return list;
            }

        }
    }
}
