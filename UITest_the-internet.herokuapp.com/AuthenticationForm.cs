using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITest_the_internet.herokuapp.com
{
    public class AuthenticationForm : BaseTestClass
    
    {
        [Test]
        public void AuthenticationFormTest()
        {
            var authenticationFormLink = driver.FindElement(By.LinkText("Form Authentication"));
            authenticationFormLink.Click();

            var usernameField = driver.FindElement(By.Id("username"));
            usernameField.SendKeys("tomsmith");

            var passwordField = driver.FindElement(By.Id("password"));
            passwordField.SendKeys("SuperSecretPassword!");


            var loginButton = driver.FindElement(By.CssSelector("#login > button > i"));
            loginButton.Click();

            var successfulLogIn = driver.FindElement(By.Id("flash"));
            Assert.That(successfulLogIn.Text, Is.EqualTo("You logged into a secure area!\r\n×"));

            var logOutButton = driver.FindElement(By.CssSelector("#content > div > a"));
            logOutButton.Click();

            var successfulLogOut = driver.FindElement(By.Id("flash-messages"));
            Assert.That(successfulLogOut.Text, Is.EqualTo("You logged out of the secure area!\r\n×"));
        
        
        }


            

    }
}
