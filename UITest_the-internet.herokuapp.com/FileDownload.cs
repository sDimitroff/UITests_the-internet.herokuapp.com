using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;
using System.Xml.Linq;
using System.IO; // we need this namespace for working with  directories and files, a reference needs to be added for this
using System.IO.Compression;// we need this namespace for working with zip files , a reference needs to be added for this
using System.Threading.Tasks;//we need this namespace to create a logical delay in time

namespace UITest_the_internet.herokuapp.com
{
    public class FileDownload 
    
    {
        [Test]
        public void FileDownloadTest()
        {

           
            
            string expectedFilePath = @"C:\Users\UserPC\Documents\sample-zip-file.zip";
            bool fileExists = false;
             
             ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("download.default_directory", @"C:\Users\UserPC\Documents\");
            options.AddUserProfilePreference("disable-popup-blocking", "true");

            WebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://the-internet.herokuapp.com/";

            var fileDownloadLink = driver.FindElement(By.LinkText("File Download"));
            fileDownloadLink.Click();

            var fileToBeDownloaded = driver.FindElement(By.LinkText("sample-zip-file.zip"));
            fileToBeDownloaded.Click();

            //Wait until the file is downloaded, otherwise driver.quit is executed before it is full downoaded and  it is actualy downloaded as ".tmp"
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
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
