using FirstCry_Shopping.POM_Framework.Extensions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCry_Shopping.Pages
{

    public class Home :SeleniumExtensions
    {
        public IWebDriver _driver = null;
        By _searchbox = By.XPath("//*[@id='search_box']");
        By _searchbutton = By.XPath("//*[@class='search-button']");
        public void HomePage(string url)
        {
          
        }
        public IWebElement search_box()
        {
            var src = Initialise._driver.FindElement(_searchbox);
            return src;
        }

        public void EnterSearchItem(string value)
        {
            enterValues(search_box(), value);
        }
       

        public IWebElement search_button()
        {
            return Initialise._driver.FindElement(_searchbutton);
        }
        public void searchClick()
        {

            clickValues(search_button());
            
        }
    }
}
`                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           HHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH