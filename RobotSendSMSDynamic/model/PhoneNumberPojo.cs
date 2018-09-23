using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSendSMSDynamic.model
{
    class PhoneNumberPojo
    {

        private String username;
        private String phoneNumber;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }


        public PhoneNumberPojo(string username, string phoneNumber)
        {
            this.username = username;
            this.phoneNumber = phoneNumber;
        }
    }
}
