using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace VeeamTask2
{
    public class CareerPage : Basis
    {
       public CareerPage(IWebDriver driver)
        {
            Basis.driver = driver;
            PageFactory.InitElements(driver, this);
        }      
        
        [FindsBy(How = How.XPath, Using = AllDepartures_Button)]
        public IWebElement btnAllDeparturs;

        [FindsBy(How = How.XPath, Using = AllLanguages_Button)]
        public IWebElement btnAllLanguage;        

        [FindsBy(How = How.XPath, Using = Language_Button_Label)]
        public IWebElement languages;

        [FindsBy(How = How.XPath, Using = Departure_Button_Label)]
        public IWebElement departureName;

        
        public int CheckCountElements()
        {            
            btnAllDeparturs.Click();            
            departureName.Click();
            btnAllLanguage.Click();
            languages.Click();
            var count = driver.FindElements(By.XPath(CountElemets_Count)).Count;
            int cnt = Convert.ToInt32(count);
            return cnt;
        }

        public const string AllDepartures_Button = "//button[text() = 'Все отделы']";
        public const string AllLanguages_Button = "//button[text() = 'Все языки']";
        public const string CountElemets_Count = "//a[contains(@class,'card')]";
        public const string Language_Button_Label = "//label[text()='Английский']";
        public const string Departure_Button_Label = "//*[@class='dropdown-item' and text()='Разработка продуктов']";
    }
}
