using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITest_the_internet.herokuapp.com
{
    public class DragAndDrop : BaseTestClass
    
    {
        [Test]
        public void DragAndDropTest()
        {
            var dragAndDropLink = driver.FindElement(By.LinkText("Drag and Drop"));
            dragAndDropLink.Click();

            var elementA = driver.FindElement(By.Id("column-a"));
            var elementB = driver.FindElement(By.Id("column-b"));

            Actions actions = new Actions(driver);
            actions.DragAndDrop(elementA, elementB).Perform();
            
            var elementAheader = driver.FindElement(By.CssSelector("#column-a > header")).Text;
           
            //Assert that elementA and elementB are exchanged 
            Assert.That(elementAheader, Is.EqualTo("B"));


            actions.DragAndDrop(elementB, elementA).Perform();
            var elementAheaderAfterFinalExchange = driver.FindElement(By.CssSelector("#column-a > header")).Text;
            
            //Assert that the first elemenet is A element
            Assert.That(elementAheaderAfterFinalExchange, Is.EqualTo("A"));
          


            


        }




    }
}
