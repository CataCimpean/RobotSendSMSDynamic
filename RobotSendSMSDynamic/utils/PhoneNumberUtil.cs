using RobotSendSMSDynamic.json;
using RobotSendSMSDynamic.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSendSMSDynamic.utils
{
    class PhoneNumberUtil
    {


        public static string getPhoneNumberForSpecificUser(String username)
        {

            if (username != null && username != "")
            {
                List<PhoneNumberPojo> phoneNumberList = ReadJSON.getPhoneNumberList(FileUtil.filePathPhoneNumber);

                foreach (PhoneNumberPojo currentReg in phoneNumberList)
                {

                    if (currentReg.Username == username)
                    {
                        return currentReg.PhoneNumber;
                    }

                }
            }
            return null;
        }
    }
}
