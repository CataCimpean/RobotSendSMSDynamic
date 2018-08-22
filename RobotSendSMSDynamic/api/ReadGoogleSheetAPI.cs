using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using System.Globalization;
using RobotSendSMSDynamic.model;
using RobotSendSMSDynamic.utils;


namespace RobotSendSMSDynamic.api
{
    class ReadGoogleSheetAPI
    {

        public static List<UserDateProgrammingPojo> getDataFromGoogleSheetAPI()
        {

            
            List<UserDateProgrammingPojo> extractedData = null;

            try
            {
                // If modifying these scopes, delete your previously saved credentials
                // at ~/.credentials/sheets.googleapis.com-dotnet-quickstart.json
                string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly };
                string ApplicationName = "Google Sheets API .NET Quickstart";
                UserCredential credential;

                using (var stream =
                    new FileStream(FileUtil.credentialsJSONPath, FileMode.Open, FileAccess.Read))
                {
                    string credPath = FileUtil.credPathForGoogleSheetApi;

                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                       GoogleClientSecrets.Load(stream).Secrets,
                       Scopes,
                       "user",
                       CancellationToken.None,
                       new FileDataStore(credPath, true)).Result;
                    Console.WriteLine("Credential file saved to: " + credPath);
                }

                // Create Google Sheets API service.
                var service = new SheetsService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });

                // Define request parameters.
                String spreadsheetId = "1CXbZGgYEiUqolQgACSFocOqWoC1kGn_0FadAE35r4Q4";


                StringBuilder range = new StringBuilder();
                range.Append(getSheetName());
                range.Append("!B4:K7");
            

                SpreadsheetsResource.ValuesResource.GetRequest request =
                        service.Spreadsheets.Values.Get(spreadsheetId, range.ToString());


                // Prints the names and majors of students in a sample spreadsheet:
                // https://docs.google.com/spreadsheets/d/1CXbZGgYEiUqolQgACSFocOqWoC1kGn_0FadAE35r4Q4/edit
                ValueRange response = request.Execute();
                IList<IList<Object>> values = response.Values;
                
                if (values != null && values.Count > 0)
                {

                    int count = 0;
                    extractedData = new List<UserDateProgrammingPojo>();
                    foreach (var row in values)
                    {
                        count = 0;
                        UserDateProgrammingPojo currentUser = new UserDateProgrammingPojo();
                        foreach (var currentValue in row)
                        {

                            count++;
                            if (count % 2 == 0)
                            {
                                Console.WriteLine("User=" + currentValue);
                                currentUser.Username = currentValue.ToString();
                                extractedData.Add(currentUser);
                                currentUser = new UserDateProgrammingPojo();

                            }
                            else
                            {
                                Console.WriteLine("Data=" + currentValue);
                                currentUser.Date = currentValue.ToString();

                            }

                        }
                    }
                }
                return extractedData;
            }
            catch (Exception ex)
            {
                HandlerErrorsUtil.handlerErrorFromGoogleAPI(ex.Message);
                return null;
            
            }
        }


        public static String getSheetName()
        {

            StringBuilder sheetName = new StringBuilder();
            sheetName.Append(DateUtil.getCurrentMonthRomanianLanguage());
            sheetName.Append(" ");
            sheetName.Append(DateUtil.getCurrentYearYYYY());

            Console.WriteLine("______________SheetName_____________=" + sheetName.ToString());
            return sheetName.ToString();
        }
    }
}
