using RobotSendSMSDynamic.controller;
using RobotSendSMSDynamic.json;
using RobotSendSMSDynamic.utils;
using RobotSendSMSDynamic.utils.email;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RobotSendSMSDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            ControllerObtainData.createJSONFile();
            ControllerSendSMS.startSendSMS();

            return;
        }
    }
}
