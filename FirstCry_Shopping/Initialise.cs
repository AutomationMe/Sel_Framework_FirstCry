using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


public static class Initialise
{
    public static IWebDriver _driver{get;set;}
  	public static void SetDriver(string _browser,string _url)
	{
        switch(_browser)

        {
            case "chrome": _driver = new ChromeDriver(".//");break;

            default:break;

        }
        _driver.Navigate().GoToUrl(_url);
        _driver.Manage().Window.Maximize();
       



    }
}
