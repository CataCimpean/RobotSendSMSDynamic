using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RobotSendSMSDynamic.utils
{
    class SeleniumUtil
    {
        public static void OpenPage(String URL)
        {

            RemoteWebDriver driver = null;
            try
            {
                driver = new EdgeDriver();


                driver.Url = URL;



                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);

                IWebElement element1 = driver.FindElement(By.XPath("//p[@class='uRhzae']")); //first element
                element1.Click();

                IWebElement element2 = driver.FindElement(By.XPath("//span[@class='RveJvd snByac']")); //second element
                element2.Click();


              //  Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }

        }
    }
}
