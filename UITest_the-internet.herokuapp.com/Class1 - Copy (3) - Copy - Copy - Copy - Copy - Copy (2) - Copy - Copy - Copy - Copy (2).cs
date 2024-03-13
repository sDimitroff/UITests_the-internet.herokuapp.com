using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITest_the_internet.herokuapp.com
{
    public class KeyPresses : BaseTestClass
    
    {
        [Test]
        public void KeyPressesTest()
        {
            driver.FindElement(By.LinkText("Key Presses")).Click();

           




        } 




    }
}
