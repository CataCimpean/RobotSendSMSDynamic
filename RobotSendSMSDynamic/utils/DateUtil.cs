using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace RobotSendSMSDynamic.utils
{
    class DateUtil
    {

        public static String getCurrentMonthMM()
        {
            return DateTime.Now.Month.ToString("00");
        }


        public static String getCurrentYearYYYY()
        {
            return DateTime.Now.Year.ToString();
        }


        public static String composeDate(String month, String day, String year)
        {
            return String.Concat(month, "/", day, "/", year);
        }

        public static Int64 ParseDateTimeToIntDay(DateTime datetime)
        {
            Int64 value = new Int64();
            Int64.TryParse(datetime.ToString("dd"), out value);
            return value;
        }

        public static String GetTomorrowAsString()
        {
            DateTime tomorrow = DateTime.Now.AddDays(1); // As DateTime
            string s_tomorrow = tomorrow.ToString("MM/dd/yyyy"); // As String
            return s_tomorrow;
        }

        public static String GetTodayAsString()
        {
            DateTime today = DateTime.Today; // As DateTime
            string s_today = today.ToString("MM/dd/yyyy"); // As String
            return s_today;
        }

        public static String getCurrentMonthRomanianLanguage()
        {

            // Creates a TextInfo based on the "en-US" culture.
            TextInfo myTitleFormat = new CultureInfo("ro-RO", false).TextInfo;


            CultureInfo ci = new CultureInfo("ro-RO");
            var month = DateTime.Now.ToString("MMMM", ci);

            return myTitleFormat.ToTitleCase(month);
        }


        public static String getNextMonthEnglishLanguage()
        {
            // Creates a TextInfo based on the "en-US" culture.
            TextInfo myTitleFormat = new CultureInfo("en-EN", false).TextInfo;
            CultureInfo ci = new CultureInfo("en-EN");
            var month = DateTime.Now.AddMonths(1).ToString("MMMM", ci);
            return myTitleFormat.ToTitleCase(month);
        }

        public static Boolean checkSunday(String date)
        {
            string[] splitted = date.Split('/');
            int month = Int32.Parse(splitted[0]);
            int day = Int32.Parse(splitted[1]);
            int year = Int32.Parse(splitted[2]);


            DateTime dateValue = new DateTime(year, month, day);

            if (dateValue.DayOfWeek.ToString().ToLower().Equals("sunday"))
            {
                return true;
            }
            return false;
        }

        public static String formatDay(String day)
        {
            String formmatedDay;
            if (day.Length == 1) {
                formmatedDay = "0" + day;

            }
            else{
                formmatedDay = day;
            }
            return formmatedDay;
        }
    }
}
