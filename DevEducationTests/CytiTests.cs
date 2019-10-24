using Dev;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using Xunit;



namespace DevEducationTests
{
    public class CytiTests
    {
        ConnectFirefox con = new ConnectFirefox();
        //[Fact]
        //public void Test1()
        //{


        //    con.driver.Navigate().GoToUrl("https://deveducation.com");

        //    Thread.Sleep(10000);
        //    con.driver.FindElement(By.CssSelector(".popup-subscribe .popup__close-icon")).Click();


        //    //con.driver.FindElement(By.CssSelector(".popup-subscribe .popup__close-icon")).Click();
        //    //con.driver.FindElement(By.XPath("//a[contains(text(),'Выпускники')]")).Click();
        //    //con.driver.FindElement(By.CssSelector(".graduates__item:nth-child(1) .play__img")).Click();




        //    //con.driver.FindElement(By.XPath("xpath=//div[7]/button")).Click();
        //    //Thread.Sleep(10000);
        //    //string actual = con.driver.FindElement(By.CssSelector(".ytp-title")).Text;
        //    //string actual = con.driver.FindElement(By.XPath("//div[contains(@class, 'ytp-title-text') and text()='Model saved']")).Text;
        //    //Thread.Sleep(10000);
        //    //Assert.Equal("Я работаю по специальности QA Engineer", actual);



        //   // con.driver.FindElement(By.XPath("xpath=//img[@alt='close img']")).Click();
        //    con.driver.FindElement(By.CssSelector(".az-point")).Click();
        //    string actual = con.driver.FindElement(By.XPath("//button[contains(.,'Баку')]")).Text;
        //    //con.driver.SwitchTo().DefaultContent();
        //    //con.driver.Url = "https://deveducation.com/";
        //    //con.driver.Navigate().Back();
        //    //con.driver.Quit();
        //    Assert.Equal("Баку", actual);
        //    //string actual = con.driver.FindElement(By.XPath("//a[contains(.,'Что такое Scrum: главные термины и их реализация в работе компании')]")).Text;
        //    con.driver.Quit();
        //    //Assert.Equal("Что такое Scrum: главные термины и их реализация в работе компании", actual);

        //}
        [Fact]
        public void OpenAllCurses()
        {
            con.driver.Navigate().GoToUrl("https://deveducation.com/en/");
            con.driver.Manage().Window.Maximize();
            Thread.Sleep(10000);
            con.driver.FindElement(By.CssSelector(".popup-subscribe .popup__close-icon")).Click();
            con.driver.FindElement(By.XPath("//a[contains(text(),'All courses')]")).Click();
            Thread.Sleep(3000);
            string actual = con.driver.FindElement(By.CssSelector(".origin-courses__title")).Text;
            Assert.Equal("Our courses", actual);
            con.driver.Quit();

        }
        [Fact]
        public void OpenDniproCurse()
        {
            con.driver.Navigate().GoToUrl("https://deveducation.com/courses/");
            con.driver.Manage().Window.Maximize();
            Thread.Sleep(10000);
            con.driver.FindElement(By.CssSelector(".popup-subscribe .popup__close-icon")).Click();
            con.driver.FindElement(By.XPath("//li[1]/a/div")).Click();
            string actual = con.driver.FindElement(By.XPath("//button[contains(.,'Днепр')]")).Text;
            Assert.Equal("Днепр", actual);
            con.driver.Quit();

        }
        [Fact]
        public void OpenKyivCurse()
        {
            con.driver.Navigate().GoToUrl("https://deveducation.com/courses/");
            con.driver.Manage().Window.Maximize();
            Thread.Sleep(10000);
            con.driver.FindElement(By.CssSelector(".popup-subscribe .popup__close-icon")).Click();
            con.driver.FindElement(By.XPath("//li[2]/a/div")).Click();
            string actual = con.driver.FindElement(By.XPath("//button[contains(.,'Киев')]")).Text;
            Assert.Equal("Киев", actual);
            con.driver.Quit();

        }
        [Fact]
        public void OpenBakyCurse()
        {
            con.driver.Navigate().GoToUrl("https://deveducation.com/courses/");
            con.driver.Manage().Window.Maximize();
            Thread.Sleep(10000);
            con.driver.FindElement(By.CssSelector(".popup-subscribe .popup__close-icon")).Click();
            con.driver.FindElement(By.XPath("//li[3]/a/div")).Click();
            string actual = con.driver.FindElement(By.XPath("//button[contains(.,'Баку')]")).Text;
            Assert.Equal("Баку", actual);
            con.driver.Quit();

        }
        [Fact]
        public void OpenStPeterburgCurse()
        {
            con.driver.Navigate().GoToUrl("https://deveducation.com/courses/");
            con.driver.Manage().Window.Maximize();
            Thread.Sleep(10000);
            con.driver.FindElement(By.CssSelector(".popup-subscribe .popup__close-icon")).Click();
            con.driver.FindElement(By.XPath("//li[4]/a/div")).Click();
            string actual = con.driver.FindElement(By.XPath("//button[contains(.,'Санкт-Петербург')]")).Text;
            Assert.Equal("Санкт-Петербург", actual);
            con.driver.Quit();


        }
        [Fact]
        public void SignUpForCoursese()
        {
            con.driver.Navigate().GoToUrl("https://deveducation.com/courses/");
            con.driver.Manage().Window.Maximize();
            Thread.Sleep(10000);
            con.driver.FindElement(By.CssSelector(".popup-subscribe .popup__close-icon")).Click();
            con.driver.FindElement(By.XPath("//div[7]/button")).Click();



            con.driver.FindElement(By.CssSelector("#entry-popup-form > .popup__wrap:nth-child(1) > .popup__input")).SendKeys("Jukov Roman");
            con.driver.FindElement(By.CssSelector("#entry-popup-form > .popup__wrap:nth-child(2) > .popup__input")).SendKeys("+380662112003");
            con.driver.FindElement(By.CssSelector("#entry-popup-form > .popup__wrap:nth-child(3) > .popup__input")).SendKeys("testmail@gmail.com");
            con.driver.FindElement(By.CssSelector("#entry-popup-form #city-popup > .form__option:nth-child(2)")).Click();


            var education = con.driver.FindElement(By.CssSelector("#entry-popup-form #city-popup"));

            var selectElement = new SelectElement(education);


            selectElement.SelectByValue("Днепр");

            education = con.driver.FindElement(By.CssSelector("#entry-popup-form #course-popup"));
            var select = new SelectElement(education);
            select.SelectByValue("QA");
            con.driver.FindElement(By.XPath("//form/div[6]/button")).Click();
            Thread.Sleep(10000);
            //string actual = con.driver.FindElement(By.CssSelector(".rc-doscaptcha-header-text")).Text;
            string actual = con.driver.FindElement(By.ClassName("rc-doscaptcha-header-text")).Text;
            Assert.Equal("Спробуйте пізніше", actual);
            con.driver.Quit();


        }
        [Fact]
        public void CheckSignUpForаCourse()
        {


            con.driver.Navigate().GoToUrl("https://deveducation.com/en/");
            con.driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(8000);
            con.driver.FindElement(By.ClassName("popup__close-icon")).Click();

            System.Threading.Thread.Sleep(5000);
            con.driver.FindElement(By.LinkText("All courses")).Click();

            System.Threading.Thread.Sleep(5000);

            //con.driver.FindElement(By.CssSelector("body > div.wrapper > main > div.fix-btn > button")).Click();


            System.Threading.Thread.Sleep(5000);

            con.driver.FindElement(By.CssSelector(".inline-form__wrap > .popup__wrap:nth-child(1) > .popup__input")).SendKeys("jukov ruman");

            con.driver.FindElement(By.CssSelector(".inline-form__wrap > .popup__wrap:nth-child(2) > .popup__input")).SendKeys("+380661112003");

            con.driver.FindElement(By.CssSelector(".inline-form__wrap > .popup__wrap:nth-child(3) > .popup__input")).SendKeys("testrmail@gmail.com");

            con.driver.FindElement(By.CssSelector("#city-popup")).SendKeys("dnipro");

            con.driver.FindElement(By.CssSelector("#course-popup")).SendKeys("qa/at");

            System.Threading.Thread.Sleep(10000);

            string actual = con.driver.FindElement(By.CssSelector("#callback__button")).Text;
            Assert.Equal("do not miss our call!", actual);
            con.driver.Quit();
        }
        [Fact]
            public void Video()
            {


            con.driver.Navigate().GoToUrl("https://deveducation.com");
            con.driver.Manage().Window.Maximize();

            Thread.Sleep(10000);
                con.driver.FindElement(By.CssSelector(".popup-subscribe .popup__close-icon")).Click();


                //con.driver.FindElement(By.CssSelector(".popup-subscribe .popup__close-icon")).Click();
                con.driver.FindElement(By.XPath("//a[contains(text(),'Выпускники')]")).Click();
                con.driver.FindElement(By.CssSelector(".graduates__item:nth-child(1) .play__img")).Click();



                //con.driver.FindElement(By.XPath("xpath=//div[7]/button")).Click();
                Thread.Sleep(10000);
                string actual = con.driver.FindElement(By.XPath("/html/body/div/div/div[3]/div[1]/div[2]/a")).Text;
                Thread.Sleep(10000);
                Assert.Equal("Я работаю по специальности QA Engineer", actual);
                Thread.Sleep(1000); con.driver.Quit();

            }
        }
    } 


