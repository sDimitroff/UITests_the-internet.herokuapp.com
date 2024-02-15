

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Xml.Linq;

namespace UITest_the_internet.herokuapp.com
{
    public class AddRemoveElements : BaseTestClass
    {

        [Test]
        public void AddOneElement()
        {
            var addRemoveElement = driver.FindElement(By.LinkText("Add/Remove Elements"));
            addRemoveElement.Click();

            var addElementButton = driver.FindElement(By.CssSelector("#content > div > button"));
            addElementButton.Click();

            var addedElement = driver.FindElement(By.ClassName("added-manually"));
            
            //assert one element is added
            Assert.True(addedElement.Displayed);

           


        }
        [Test]
        public void addThreeElement ()
        {
            var addRemoveElement = driver.FindElement(By.LinkText("Add/Remove Elements"));
            addRemoveElement.Click();

            var addElementButton = driver.FindElement(By.CssSelector("#content > div > button"));
            addElementButton.Click();
            addElementButton.Click();
            addElementButton.Click();

            var elements = driver.FindElement(By.CssSelector("#elements"));
            var allAddedElements = elements.FindElements(By.ClassName("added-manually"));

            //assert 3 elements are added after 3 clicks
            Assert.True(allAddedElements[2].Displayed);



        }

        [Test]
        public void deleteElement()
        {
            var addRemoveElement = driver.FindElement(By.LinkText("Add/Remove Elements"));
            addRemoveElement.Click();

            // Add three elements
            var addElementButton = driver.FindElement(By.CssSelector("#content > div > button"));
            addElementButton.Click();
            addElementButton.Click();
            addElementButton.Click();

            var elements = driver.FindElement(By.CssSelector("#elements"));
            var allAddedElements = elements.FindElements(By.ClassName("added-manually"));
            allAddedElements[2].Click();
           
            
            var allRemainedElements = elements.FindElements(By.ClassName("added-manually"));
            var lastElement = allRemainedElements.Last();

             
           // Assert.AreEqual(lastElement, allRemainedElements[1]);
            Assert.That(lastElement, Is.EqualTo(allRemainedElements[1]));
            Console.WriteLine(allRemainedElements.Last());
            Console.WriteLine(allRemainedElements[1]);

        }
        
    }
}