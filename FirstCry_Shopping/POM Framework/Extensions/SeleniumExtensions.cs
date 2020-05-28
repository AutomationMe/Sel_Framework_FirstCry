using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace FirstCry_Shopping.POM_Framework.Extensions
{

    public class SeleniumExtensions
    {
        public bool IsAvailable(IWebElement element)
        {
            bool avail = false;
            int counter = 10;
            while (counter>0)
            {

                try
                {
                    avail = element.Displayed;
                }
                catch
                {
                    Thread.Sleep(1);
                    counter -= 1;
                                    } 
            }
            return avail;
        }
        public bool IsClickable(IWebElement element)
        {
            bool avail = false;
            int counter = 10;
            while (counter > 0)
            {

                try
                {
                    avail = element.Enabled;
                }
                catch
                {
                    Thread.Sleep(1);
                    counter -= 1;
                }
            }
            return avail;
        }

        public void enterValues(IWebElement element, string text)
        {
            
            if(IsAvailable(element))
            {
                element.Clear();
                element.SendKeys(text);
            }
          
        }
        public void clickValues(IWebElement element)
        {
                       
            
            if (IsClickable(element))
            {
                element.Click();
            }
        }


    }
}
