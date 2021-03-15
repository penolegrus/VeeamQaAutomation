using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace VeeamTask2
{
    [TestFixture]
    public class Tests : Basis
    {           
        [Test]
        public void AssertCount()
        {
            driver.Navigate().GoToUrl(baseurl);            
            CareerPage careerPage = new CareerPage(driver);
            InitPage(careerPage);
            uint expectcount = 5; //Ожидаемое количество вакансий
            int realcount = careerPage.CheckCountElements();
            Assert.AreEqual(expectcount, realcount);
        }
        
    }
}