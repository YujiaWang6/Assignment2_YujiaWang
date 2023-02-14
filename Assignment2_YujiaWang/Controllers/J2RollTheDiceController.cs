using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_YujiaWang.Controllers
{
    public class J2RollTheDiceController : ApiController
    {
        /// <summary>
        /// There are two dice, one dice has m sides (1, 2, 3 ... , m), another dice has n sides (1, 2, 3 ... , n).
        /// Write a program which determines how many ways the dices can be rolled the value of 10.
        /// </summary>
        /// <param name="m">The number of side of the first dice</param>
        /// <param name="n">The number of side of the second dice</param>
        /// <returns>A string about how many ways the two dices can be rolled the value of 10</returns>
        /// <example>GET ../api/J2RollTheDice/DiceGame/6/8   -> There are 5 total ways to get the sum 10</example>
        /// <example>GET ../api/J2RollTheDice/DiceGame/12/4  -> There are 4 ways to get the sum 10.</example>
        /// <example>GET ../api/J2RollTheDice/DiceGame/3/3   -> There are 0 ways to get the sum 10.</example>
        /// <example>GET ../api/J2RollTheDice/Dicegame/5/5   -> There is 1 way to get the sum 10.</example>
        [HttpGet]
        [Route("api/J2RollTheDice/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
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
            return message;
        }
    }
}
