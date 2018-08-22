using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSendSMSDynamic.model
{
    class UserDateProgrammingPojo
    {

        private string username;
        private string date;


        public string Username
        {
            get { return username; }
            set { username = value; }
        }


        public string Date
        {
            get { return date; }
            set { date = value; }
        }


        public UserDateProgrammingPojo(string username, string date)
        {
            this.username = username;
            this.date = date;
        }
        public UserDateProgrammingPojo() { }
    }
}
