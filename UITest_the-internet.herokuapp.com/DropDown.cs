using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
namespace UITest_the_internet.herokuapp.com
{
    public class DropDown : BaseTestClass
    
    {
        [Test]
        public void DropDownTest()
        {
            var dropDownLink = driver.FindElement(By.LinkText("Dropdown"));
            dropDownLink.Click();

            var dropDownMenu = driver.FindElement(By.Id("dropdown"));
            
            SelectElement select = new SelectElement(dropDownMenu);
            select.SelectByValue("1");

            var selectedOption1 = driver.FindElement(By.CssSelector("#dropdown > option:nth-child(2)"));
           
            //Assert option1 is selected
            Assert.True(selectedOption1.Selected);

            
            select.SelectByValue("2");
            var selectedOption2 = driver.FindElement(By.CssSelector("#dropdown > option:nth-child(3)"));
            
            //Assert option2 is selected
            Assert.True(selectedOption2.Selected);



           


        }




    }
}
