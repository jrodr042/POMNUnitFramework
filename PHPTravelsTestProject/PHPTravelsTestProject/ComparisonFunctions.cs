using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PHPTravelsTestProject.UIElements;

namespace PHPTravelsTestProject
{
    class ComparisonFunctions
    {
        //classNames for star rating
        private static string FullStar = "star fa fa-star";
        //private static string EmptyStar = "star fa fa-star-o";


        public bool MarchNumberOfstars(IWebElement block, int starNumber)
        {
            //create a hitcounter to count the number of times we have a match
            int hitCounter = 0;
            

            //create a list of of the child elments
            IReadOnlyList<IWebElement> childs = block.FindElements(By.XPath(".//*"));

            foreach (IWebElement item in childs)
            {

                if (item.GetAttribute("class").Equals(FullStar))
                {
                    hitCounter++;
                    Console.WriteLine(item.GetAttribute("class"));
                }
            }

            //return if we matched the correct number of stars or no
            if(hitCounter == starNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
