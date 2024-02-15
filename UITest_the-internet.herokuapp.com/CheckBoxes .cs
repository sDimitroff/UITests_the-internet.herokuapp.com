using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using System.Collections.ObjectModel;

namespace UITest_the_internet.herokuapp.com
{
    internal class CheckBox : BaseTestClass
    {

        

        [Test]
        public void CheckedBox()
        {


            var checkBoxLink = driver.FindElement(By.LinkText("Checkboxes"));
            checkBoxLink.Click();
            
            
            var checkBox = driver.FindElement(By.CssSelector("#checkboxes > input[type=checkbox]:nth-child(1)"));
            checkBox.Click();

            var element = driver.FindElement(By.CssSelector("#checkboxes > input[type=checkbox]:nth-child(1)"));
            bool isSlelected = element.Selected;
            
            //Assert that check box is checked
            Assert.True(isSlelected); 
            Thread.Sleep(3000);
        }

        [Test]
        public void UnCheckedBox()
        {


            var checkBoxLink = driver.FindElement(By.LinkText("Checkboxes"));
            checkBoxLink.Click();


            var checkBox1 = driver.FindElement(By.CssSelector("#checkboxes > input[type=checkbox]:nth-child(3)"));
            checkBox1.Click();

            var element = driver.FindElement(By.CssSelector("#checkboxes > input[type=checkbox]:nth-child(1)"));
            bool isSlelected = element.Selected;

            //Assert that check box is NOT checked
            Assert.False(isSlelected);
            Thread.Sleep(3000);
        }
    }
}
