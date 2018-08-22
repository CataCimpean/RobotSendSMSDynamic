using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSendSMSDynamic.model
{
    class VideoproiectiePojo
    {

        #region fields(username,phoneNumber,dateProgramming,sunday_morning,sunday_evening)

        private string username;
        private string phoneNumber;
        private string dateProgramming;
        private string sunday_morning;
        private string sunday_evening;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string DateProgramming
        {
            get { return dateProgramming; }
            set { dateProgramming = value; }
        }

        public string Sunday_morning
        {
            get { return sunday_morning; }
            set { sunday_morning = value; }
        }

        public string Sunday_evening
        {
            get { return sunday_evening; }
            set { sunday_evening = value; }
        }

        #endregion

        #region constructor

        public VideoproiectiePojo(string username, string phoneNumber, string dateProgramming, string sunday_morning, string sunday_evening)
        {
            this.username = username;
            this.phoneNumber = phoneNumber;
            this.dateProgramming = dateProgramming;
            this.sunday_morning = sunday_morning;
            this.sunday_evening = sunday_evening;
        }

        #endregion
    }
}
