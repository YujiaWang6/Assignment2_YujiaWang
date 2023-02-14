using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_YujiaWang.Controllers
{
    public class J1FastFoodController : ApiController
    {
        /// <summary>
        /// Write a program that will compute the total Calories of the meal. There are 4 categories(burger, drink, side, dessert) in total.
        /// Each category has 4 different choices which with different calories.
        /// burger:1.cheeseBurger(461 Calories), 2.fishBurger(431 Calories), 3.veggieBurger(420 Calories), 4.noBurger(0 Calories).
        /// drink: 1.softDrink(130 Calories), 2.orangeJuice(160 Calories), 3.milk(118 Calories), 4.noDrink(0 Calories).
        /// side: 1.fires(100 Calories), 2.bakedPotato(57 Calories), 3.chefSalad(70 Calories), 4.noSide(0 Calories).
        /// dessert: 1.applePie(167 Calories), 2.sundae(266 Calories), 3.fruitCup(75 Calories),4.noDessert(0 Calories).
        /// </summary>
        /// <param name="burger">Integer representing the index burger choice</param>
        /// <param name="drink"> Integer representing the index drink choice</param>
        /// <param name="side"> Integer representing the index side choice</param>
        /// <param name="dessert"> Integer representing the index dessert choice</param>
        /// <returns>Return a string with the total Calories of the meal based on the input index of choice</returns>
        /// <example>GET ../api/J1FastFood/Menu/4/4/4/4  -> Your total calorie count is 0</example>
        /// <example>GET ../api/J1FastFood/Menu/1/2/3/4  -> Your total calorie count is 691</example>
        [HttpGet]
        [Route("api/J1FastFood/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            int cheeseBurger = 461;
            int fishBurger = 431;
            int veggieBurger = 420;
            int softDrink = 130;
            int orangeJuice = 160;
            int milk = 118;
            int fires = 100;
            int bakedPotato = 57;
            int chefSalad = 70;
            int applePie = 167;
            int sundae = 266;
            int fruitCup = 75;
            int noChoice = 0;

            int burgerCalories;
            int drinkCalories;
            int sideCalories;
            int dessertCalories;
            int totalCalories;
            string message = "";

            if (burger == 1)
            {
                burgerCalories = cheeseBurger;
            }else if(burger == 2)
            {
                burgerCalories= fishBurger;
            }else if(burger == 3)
            {
                burgerCalories = veggieBurger;
            }else 
            {
                burgerCalories = noChoice;
            }

            if(drink == 1)
            {
                drinkCalories = softDrink;
            }else if(drink == 2)
            {
                drinkCalories = orangeJuice;

            }else if(drink == 3)
            {
                drinkCalories = milk;
            }else
            {
                drinkCalories = noChoice;
            }
            
            if(side == 1)
            {
                sideCalories = fires;
            }else if(side == 2)
            {
                sideCalories = bakedPotato;
            }else if(side == 3)
            {
                sideCalories = chefSalad;
            }else
            {
                sideCalories = noChoice;
            }

            if(dessert == 1)
            {
                dessertCalories = applePie;
            }else if(dessert == 2)
            {
                dessertCalories = sundae;
            }else if(dessert == 3)
            {
                dessertCalories = fruitCup;
            }else
            {
                dessertCalories = noChoice;
            }

            totalCalories = burgerCalories + drinkCalories + sideCalories + dessertCalories;

            message = "Your total calorie count is " + totalCalories.ToString();

            return message;
        }
    }
}
