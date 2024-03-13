using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITest_the_internet.herokuapp.com
{
    public class HorizontalSlider : BaseTestClass
    
    {
        [Test]
        public void HorizontalSliderTest()
        {
            driver.FindElement(By.LinkText("Horizontal Slider")).Click();

            var slider = driver.FindElement(By.CssSelector("#content > div > div > input[type=range]"));
            
            slider.SendKeys(Keys.ArrowRight);
            slider.SendKeys(Keys.ArrowRight);
            slider.SendKeys(Keys.ArrowRight);

            Task.Delay(3000).Wait();
            var sliderRange = driver.FindElement(By.CssSelector("#range"));


            // Assert that slider range is moved at 1.5
            Assert.That(sliderRange.Text, Is.EqualTo("1.5"));
        
            



        }

        



    }
}
