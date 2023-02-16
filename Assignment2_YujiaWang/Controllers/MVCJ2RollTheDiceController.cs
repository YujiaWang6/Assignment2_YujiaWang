using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment2_YujiaWang.Controllers
{
    public class MVCJ2RollTheDiceController : Controller
    {

        /// <summary>
        /// There are two dice, one dice has m sides (1, 2, 3 ... , m), another dice has n sides (1, 2, 3 ... , n).
        /// Write a program which determines how many ways the dices can be rolled the value of 10.
        /// </summary>
        /// <param name="m">The number of side of the first dice</param>
        /// <param name="n">The number of side of the second dice</param>
        /// <returns>A string about how many ways the two dices can be rolled the value of 10</returns>
        /// <example>GET ../localhost:xxxxx/MVCJ2RollTheDice/roll?m=6&n=8   -> There are 5 total ways to get the sum 10</example>
        /// <example>GET ../localhost:xxxxx/MVCJ2RollTheDice/roll?m=12&n=4   -> There are 4 ways to get the sum 10.</example>
        /// <example>GET ../localhost:xxxxx/MVCJ2RollTheDice/roll?m=3&n=3  -> There are 0 ways to get the sum 10.</example>
        /// <example>GET ../localhost:xxxxx/MVCJ2RollTheDice//roll?m=5&n=5  -> There is 1 way to get the sum 10.</example>



        // GET: localhost:xxxxx/MVCJ2RollTheDice/dice
        //page to get the input of the two dices
        public ActionResult dice()
        {
            return View();
        }


        // GET: localhost:xxxxx/MVCJ2RollTheDice/roll?m={input of m side}&n={input of n side}
        //page to show the result
        public ActionResult roll(int m, int n) 
        {
            int count = 0;
            string message = "";

            while (m > 0)
            {

                for (int i = n; i > 0; i = i - 1)
                {

                    if (m + i == 10)
                    {
                        
                        count = count + 1;
                    }

                }
                m = m - 1;
            }

            message = "There are " + count.ToString() + " ways to get the sum 10.";

            ViewData["message"]=message;

            return View();
        }
    }
}