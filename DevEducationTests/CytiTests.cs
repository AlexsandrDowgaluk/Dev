using Dev;
using OpenQA.Selenium;
using System;
using Xunit;


namespace DevEducationTests
{
    public class CytiTests
    {
        [Fact]
        public void Test1()
        {
            ConnectFirefox con = new ConnectFirefox();

            //Thread.Sleep(2000);
            //con.driver.FindElement(By.XPath("xpath=//img[@alt='close img']")).Click();
            con.driver.FindElement(By.CssSelector(".az-point")).Click();
            string actual = con.driver.FindElement(By.XPath("//button[contains(.,'Баку')]")).Text;
            con.driver.Quit();
            Assert.Equal("Баку", actual);
        }
    }
}
