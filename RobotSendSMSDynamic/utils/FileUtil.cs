using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSendSMSDynamic.utils
{
    class FileUtil
    {
        #region variables(filenameJSONProgamming,filePathJSONProgramming ,fileWithPhoneNumber,filePathPhoneNumber)
        public const string filenameJSONProgamming = "VideoProiectieProgramare.json";
        public static string filePathJSONProgramming = AppDomain.CurrentDomain.BaseDirectory + @"dateUtile" + "\\" + filenameJSONProgamming;
        public const string fileWithPhoneNumber = "nrTelefoane.json";
        public static string filePathPhoneNumber = AppDomain.CurrentDomain.BaseDirectory + @"dateUtile" + "\\" + fileWithPhoneNumber;
        public static string credentialsJSONPath = AppDomain.CurrentDomain.BaseDirectory + "credentials.json";
        public static string credPathForGoogleSheetApi = AppDomain.CurrentDomain.BaseDirectory + "token.json";

        
        #endregion




    }
}
