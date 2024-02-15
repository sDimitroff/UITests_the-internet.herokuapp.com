using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;

namespace UITest_the_internet.herokuapp.com
{
    public class FileUploadTest : BaseTestClass
    
    {
        [Test]
        public void FileUpload()
        {
           // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            var fileUploadLink = driver.FindElement(By.LinkText("File Upload"));
            fileUploadLink.Click();

            var fileUploadButton = driver.FindElement(By.Id("file-upload"));
            fileUploadButton.SendKeys("C:\\Users\\UserPC\\Pictures\\0_165795824382.jpg");

            var submitFileButton = driver.FindElement(By.Id("file-submit"));
            submitFileButton.Click();

            var fileUploadedStatus = driver.FindElement(By.CssSelector("#content > div > h3"));
            
            // Assert that file is uploaded
            Assert.True(fileUploadedStatus.Displayed);
            

        }




    }
}
