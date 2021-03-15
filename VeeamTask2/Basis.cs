using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace VeeamTask2
{
    public class Basis
    {
        protected string baseurl = "https://careers.veeam.ru/vacancies";
        public static IWebDriver driver;

        public static void InitPage<T>(T pageClass) where T : Basis
        {
            PageFactory.InitElements(driver, pageClass);
        }

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait.Add(System.TimeSpan.FromSeconds(15));
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(10));
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }

    }
}
