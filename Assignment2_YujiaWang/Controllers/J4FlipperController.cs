using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;

namespace Assignment2_YujiaWang.Controllers
{
    public class J4FlipperController : ApiController
    {
        /// <summary>
        /// 2019Problem J4/S1: Flipper
        /// There are a grid of four numbers, and there are two ways to flip it: horizontal (H) and verticle (v)
        /// 1 2   ->  3 4     horizontal flip
        /// 3 4       1 2    
        /// 1 2   ->  2 1     vertical flip
        /// 3 4       4 3
        /// </summary>
        /// <param name="flip">Input the string with the instruction (eg:HVVVHHV)</param>
        /// <returns>The final position of all the numbers after flips</returns>
        /// <example>
        /// POST: api/J4Flipper/flipper/HV     ->  4 3
        ///                                        2 1
        /// </example>
        /// <example>
        /// POST: api/J4Flipper/flipper/VVHH  ->   1 2
        ///                                        3 4
        /// </example>
        [HttpPost]
        [Route("api/J4Flipper/flipper/{flip}")]
        public object flipper(string flip)
        {

            int[] grid = { 1, 2, 3, 4 }; 
            //seperate flip into each H or V
            char[] instruction = flip.ToCharArray();
            int a;
            int b;
            int c;
            int d;
            int[] gridUpdate = grid;

            int i = 1;
            while ( i<= instruction.Length)
             {
                 char eachStep = instruction[i-1];
                 if (eachStep == 'H')
                 {
                     //grid = {a, b, c, d}  -> if horizontal flip, grid_update = {c, d, a, b}
                     a = gridUpdate[0];//current 1st number
                     b = gridUpdate[1];//current 2nd number
                     c = gridUpdate[2];//current 3rd number
                     d = gridUpdate[3];//current 4th number

                     //reput it back into new position
                     gridUpdate[2] = a;
                     gridUpdate[3] = b;
                     gridUpdate[0] = c;
                     gridUpdate[1] = d;
                 }
                 else
                 {
                    
                     //grid = {a, b, c, d}  -> if vertical flip, grid_update = {b, a, d, c}
                     a = gridUpdate[0];
                     b = gridUpdate[1];
                     c = gridUpdate[2];
                     d = gridUpdate[3];

                     gridUpdate[1] = a;
                     gridUpdate[0] = b;
                     gridUpdate[3] = c;
                     gridUpdate[2] = d;
                     
                 }

                 i++;
             }
            int[,] finalGrid = { { gridUpdate[0], gridUpdate[1] }, { gridUpdate[2], gridUpdate[3] } };

            return finalGrid;
             
        }
    }
}



//find the way to seperate string into character: char[] array = {stringname}.ToCharArray()
//put the 1,2,3,4 into original array, and extract from array everytime with the current array,then put it back with different order(depending on H or V)
//finally put the value in update array into matrix(finalGrid)
//tested variable             
//int x = instruction.Length;
//char y = instruction[0];
//grid = {a, b, c, d}  -> if horizontal flip, grid_update = {c, d, a, b}
//a = grid[2];
//b = grid[3];
// c = grid[0];
// d = grid[1];
//grid = {a, b, c, d}  -> if vertical flip, grid_update = {b, a, d, c}
//a = grid[1];
//b = grid[0];
//c = grid[3];
//d = grid[2];
