using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITest_the_internet.herokuapp.com
{
    public class JQueryUIMenus 
    
    {
        [Test]
        public void JQueryUIMenusTest()
        {
            string expectedFilePath = @"C:\Users\UserPC\Downloads\menu.pdf";
            
            bool fileExists = false;


            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("download.default_directory", @"C:\Users\UserPC\Downloads\");
            options.AddUserProfilePreference("disable-popup-blocking", "true");

            WebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://the-internet.herokuapp.com/";



            driver.FindElement(By.LinkText("JQuery UI Menus")).Click();

            var enabledButton = driver.FindElement(By.LinkText("Enabled"));

            enabledButton.Click();
            Task.Delay(1000).Wait();
            var downloadButton = driver.FindElement(By.LinkText("Downloads"));
            downloadButton.Click();

            Task.Delay(2000).Wait();
            

            var pdfButton = driver.FindElement(By.LinkText("PDF"));
            pdfButton.Click();
            


            //Wait until the file is downloaded, otherwise driver.quit is executed before it is full downoaded and  it is actualy downloaded as ".tmp"
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until<bool>(x => fileExists = File.Exists(expectedFilePath));


            //Delete file after it is downloaded
            bool result = File.Exists(expectedFilePath);
            if (result == true)
            {
                File.Delete(expectedFilePath);
            }

            else
            {
                Assert.Fail("The file does not exist.");
            }


           
          
          

            driver.Quit();





        }




    }
}
