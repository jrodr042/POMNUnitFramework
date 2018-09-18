using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PHPTravelsTestProject.UIElements;

namespace PHPTravelsTestProject.Helper_Classes
{
    static class DropDownSelector
    {
        public static void SelectFromDropdown(this IWebElement list, string itemInList)
        {
            list.Click();
            Thread.Sleep(100);
            SelectElement item = new SelectElement(list);
            item.SelectByText(itemInList);
            Thread.Sleep(1000);
            list.Click();
        }


    }
}
