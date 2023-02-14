using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_YujiaWang.Controllers
{
    public class J3AreWeThereYet2018Controller : ApiController
    {
        /// <summary>
        /// There are 5 cities along the road and a person is walking on the road and recording the distance between each pair of consecutive cities.
        /// This program are taking 4 distances between consecutive pairs of consecutive cities as input and output a 5x5 tables containing the distance between city i(from 1 to 5) to each other city(from 1 to 5)
        /// </summary>
        /// <param name="d1">the distance between the first city to the second city</param>
        /// <param name="d2">the distance between the second city to the third city</param>
        /// <param name="d3">the distance between the third city to the fourth city</param>
        /// <param name="d4">the distance between the fourth city to the fifth city</param>
        /// <returns>a 5x5 tables including the distance between object city(from 1 to 5) to each other city(from 1 to 5)</returns>
        /// <example>
        /// POST: api/J3AreWeThereYet2018/Distance/3/10/12/5   -> 0 3 13 25 30
        ///                                                      3 0 10 22 27
        ///                                                      13 10 0 12 17
        ///                                                      25 22 12 0 5
        ///                                                      30 27 17 5 0
        ///</example>
        [HttpPost]
        [Route("api/J3AreWeThereYet2018/Distance/{d1}/{d2}/{d3}/{d4}")]

        //Please use terminal to check the results
        public object Distance(int d1, int d2, int d3, int d4)
        {
            //put all the distance into an array & set an all 0 matrix(5x5) to hold the value
            int[] dist = {0, d1,d2,d3,d4 };
            int[,] calculate = { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };

            //i is the object city(represent in row) & j is the other citys(represent in column)
            int i = 1;
            int j = 1;
            //set distance between two cities to be 0
            int distance = 0;
        
            //using while loops to increase i and j
            while (i < 6)
            {
               
                //reset the j=1 for every loop of i
                j = 1;       
                while (j < 6)
                {
                    //for each object city(i), checking the position of other city(if it is before the object or equal or after)
                    //if the i==j, checking city is the object city, distance =0 
                    //then, push the value into the setting matrix
                    if (i == j)
                    {
                        distance = 0;
                        calculate[i-1, j-1] = distance;
                    }
                    else
                    {
                        //if checking city is after object city, adding the distance accordingly and push the value into the setting matrix
                        if (j > i)
                        {
                            distance = 0;
                            for (int m = j;m>i;m--)
                            {
                                distance = distance + dist[m-1];
                            }
                            calculate[i-1, j-1] = distance;
                        }
                        //if checking city is before object city, adding the distance accordingly and push the value into the setting matrix
                        else
                        {
                            distance = 0;
                            for(int n = j; n < i; n++)
                            {
                                distance = distance + dist[n];
                            }
                            calculate[i-1, j-1] = distance;
                        }
                    }

                    j++;
                }
                
                i++;
            }


            return calculate;
            
        }
 

    }
}




//how to return matrix?: using public object to return multidimensional array?why object cannot return in url?
//how to set the matrix?: sample of setting matrix//int[,] calculate = { { d1, d2, d3, d4,d1 }, { d4, d2, d3,d4,d1 }, { d4, d2, d3, d4,d1 }, { d4, d2, d3, d4 ,d3}, { d4, d2, d3, d4, d3 } };
//find how to push value into matrix: calculate[0, 0] = 50; index from 0
//distance as an array, using index to pull the data
//matrix is setting as [i,j]. using while loop to increase i and j(i is curring object city (in row) and j is the checking city)
//check the j position(if before i, should be able to pull more than 1 value from array and add together
//using while loop, not working properly? The j is not set back to 1 after first loop of i. using message to output the combination
//condition of j>i setting wrong, should have higher value approach to the lower value
//after the for loop, distance is not setting to 0