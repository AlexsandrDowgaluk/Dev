using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;



namespace Dev
{
    public class ConnectFirefox
    {
        public IWebDriver driver;
       

        public ConnectFirefox()


        {
            Initialize();

           // driver.Navigate().GoToUrl("https://deveducation.com");
        }
        public void Initialize()
        {
            
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
            service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            driver = new FirefoxDriver(service);


        }
    }
}
