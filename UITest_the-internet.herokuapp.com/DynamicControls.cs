using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;

namespace UITest_the_internet.herokuapp.com
{
    public class DynamicControls : BaseTestClass
    
    {

       


        [Test]
        public void DynamicControlsTest()
        {
            var dynamicControlLink = driver.FindElement(By.LinkText("Dynamic Controls"));
            dynamicControlLink.Click();

            var checkBox = driver.FindElement(By.CssSelector("#checkbox > input[type=checkbox]"));
            checkBox.Click();

            Assert.True(checkBox.Selected);

            var removeButton = driver.FindElement(By.CssSelector("#checkbox-example > button"));
            removeButton.Click();

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var disappearingCheckBox = wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.CssSelector("#checkbox > input[type=checkbox]")));

            


            try
            {
                var disappearedBox = driver.FindElement(By.CssSelector("#checkbox > input[type=checkbox]"));
                Assert.True(disappearedBox.Displayed);
                Console.Write("Checked box is still visible");
            }

            catch (OpenQA.Selenium.NoSuchElementException ex)
            {
                Console.WriteLine("Checked box is not visible after Remove button is clicked");

            }

            var addButton = driver.FindElement(By.CssSelector("#checkbox-example > button"));
            //Assert  Add button text is "Add"
            Assert.That(addButton.Text, Is.EqualTo("Add"));

            var textItsGone = driver.FindElement(By.Id("message"));
            //Assert "It's gone text is displayed"
            Assert.True(textItsGone.Displayed);

        }
        
        [Test]
        public void EnableDisableTest()
        {
            var dynamicControlLink = driver.FindElement(By.LinkText("Dynamic Controls"));
            dynamicControlLink.Click();

            var inputField = driver.FindElement(By.CssSelector("#input-example > input[type=text]"));
           
            //assert that input field is disabled
            Assert.False(inputField.Enabled);


            var enableDisableButton = driver.FindElement(By.CssSelector("#input-example > button"));
            enableDisableButton.Click();

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(inputField));
            
            //assert that the input field is enabled
            Assert.True(inputField.Enabled);
        }



    }
}
