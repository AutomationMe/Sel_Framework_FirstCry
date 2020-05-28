using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstCry_Shopping.Pages;
using NUnit.Framework;


namespace FirstCry_Shopping
{
    [TestClass]
    public class TestCases
    {
        Home home;
      
        [OneTimeSetUp]
        public void initialize()
        {
          Initialise.SetDriver("chrome", "https://www.firstcry.com/"); 
        }
        [TestMethod]
        public void TC01_Add_an_item_using_Search()
        {//Search item using text box and add to cart
            Home home = new Home();
           home.EnterSearchItem("Mamy Poko pants");
           home.searchClick();


        }

        [TestMethod]
        public void TC02_Add_an_Item_using_dropdown()
        {

        }
        [TestMethod]
        public void TC03_Shortlisting_items()
        {

        }
        [TestMethod]
        public void TC04_Remove_items_from_Cart()
        {

        }

        [TearDown]
        public void End()
        {
            Initialise._driver.Quit();

        }
    }
}
