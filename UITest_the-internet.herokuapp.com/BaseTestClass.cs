using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITest_the_internet.herokuapp.com
{
    public class BaseTestClass
    {

        protected WebDriver driver;


        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://the-internet.herokuapp.com/";
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
