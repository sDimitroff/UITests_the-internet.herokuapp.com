using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITest_the_internet.herokuapp.com
{
    public class Typos : BaseTestClass

    {
        [Test]
        public void TyposTest()
        {
            driver.FindElement(By.LinkText("Typos")).Click();

            var typoMessage = driver.FindElement(By.CssSelector("#content > div > p:nth-child(3)")).Text;

            Task.Delay(1000).Wait();
            if (typoMessage.Contains("won,t"))
            {
                Console.WriteLine("There is a typo in the text before refresh");
            }
            else
            {
                Console.WriteLine("The text before refresh is correct");
            }

            driver.Navigate().Refresh();

            Task.Delay(3000).Wait();

            var typoMessageAfterRefresh = driver.FindElement(By.CssSelector("#content > div > p:nth-child(3)")).Text;

            if (typoMessageAfterRefresh.Contains("won,t"))
            {
                Console.WriteLine("There is a typo in the text after refresh");
            }
            else
            {
                Console.WriteLine("The text after refresh is correct");
            }



        }




    }
}
