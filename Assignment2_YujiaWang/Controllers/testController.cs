using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Xml;

namespace Assignment2_YujiaWang.Controllers
{
    public class testController : ApiController
    {
        [Route("api/test/")]

        public string Get()
        {

            int i = 1;
            int j = 1;
            string message = "";

            while (i < 5)
            {
                j = 1;
                while (j < 5)
                {
                    message = message + i + j + "    ";
                    j++;
                }
                i++;
            }

            return message;
        }

        public object Getmatrix() 
        { 
            
            int[] ca = { 1, 2 };
            //int[,] calculate = { { 2,3},{ 4,3 } };
            int[,] arr = { { 4,2 },{ 6,4 } };

            //calculate[0, 0] = 1;
            //calculate[0, 1] = 1;
            //calculate[1, 1] = 1;
            //calculate[1, 0] = 2;
            return arr;
        }
    }
}
