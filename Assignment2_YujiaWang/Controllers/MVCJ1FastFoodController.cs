using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment2_YujiaWang.Controllers
{
    public class MVCJ1FastFoodController : Controller
    {
        /// <summary>
        /// Write a program that will compute the total Calories of the meal. There are 4 categories(burger, drink, side, dessert) in total.
        /// Each category has 4 different choices which with different calories.
        /// burger:1.cheeseBurger(461 Calories), 2.fishBurger(431 Calories), 3.veggieBurger(420 Calories), 4.noBurger(0 Calories).
        /// drink: 1.softDrink(130 Calories), 2.orangeJuice(160 Calories), 3.milk(118 Calories), 4.noDrink(0 Calories).
        /// side: 1.fires(100 Calories), 2.bakedPotato(57 Calories), 3.chefSalad(70 Calories), 4.noSide(0 Calories).
        /// dessert: 1.applePie(167 Calories), 2.sundae(266 Calories), 3.fruitCup(75 Calories),4.noDessert(0 Calories).
        /// </summary>
        /// <param name="customerName">Input customer name</param>
        /// <param name="burger">Integer representing the index burger choice</param>
        /// <param name="drink"> Integer representing the index drink choice</param>
        /// <param name="side"> Integer representing the index side choice</param>
        /// <param name="dessert"> Integer representing the index dessert choice</param>
        /// <returns>Return a string with the total Calories of the meal based on the input index of choice</returns>
        /// <example>GET:localhost:xxxxx/MVCJ1FastFood/caloriesCal?customerName=Yujia&burger=4&drink=4&side=4&dessert=4 -> Hello, Yujia. Your total calorie count is 0
        ///                                                                                                                Your burger calorie is: 0
        ///                                                                                                                Your drink calorie is: 0
        ///                                                                                                                Your side calorie is: 0
        ///                                                                                                                Your dessert calorie is: 0  </example>
        /// <example>GET:localhost:xxxxx/MVCJ1FastFood/caloriesCal?customerName=Yujia&burger=1&drink=2&side=3&dessert=4  -> Hello, Yujia. Your total calorie count is 691
        ///                                                                                                                Your burger calorie is: 461
        ///                                                                                                                Your drink calorie is: 160
        ///                                                                                                                Your side calorie is: 70
        ///                                                                                                                Your dessert calorie is: 0  </example>



        // GET: localhost:xxxxx/MVCJ1FastFood/fastFood
        //Page to pick your order
        public ActionResult fastFood()
        {
            return View();
        }

        
        // GET: localhost:xxxxx/MVCJ1FastFood/caloriesCal?customerName={name}&burger={index of burger}&drink={index of drink}&side={index of side}&dessert={index of dessert}
        //page to get the result
        public ActionResult caloriesCal(string customerName, int burger, int drink, int side, int dessert)
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
                ViewData["burger"] = cheeseBurger;
            }
            else if (burger == 2)
            {
                burgerCalories = fishBurger;
                ViewData["burger"] = fishBurger;
            }
            else if (burger == 3)
            {
                burgerCalories = veggieBurger;
                ViewData["burger"] = veggieBurger;
            }
            else
            {
                burgerCalories = noChoice;
                ViewData["burger"] = noChoice;
            }

            if (drink == 1)
            {
                drinkCalories = softDrink;
                ViewData["drink"] = softDrink;
            }
            else if (drink == 2)
            {
                drinkCalories = orangeJuice;
                ViewData["drink"] = orangeJuice;

            }
            else if (drink == 3)
            {
                drinkCalories = milk;
                ViewData["drink"] = milk;
            }
            else
            {
                drinkCalories = noChoice;
                ViewData["drink"] = noChoice;
            }

            if (side == 1)
            {
                sideCalories = fires;
                ViewData["side"] = fires;
            }
            else if (side == 2)
            {
                sideCalories = bakedPotato;
                ViewData["side"] = bakedPotato;
            }
            else if (side == 3)
            {
                sideCalories = chefSalad;
                ViewData["side"] = chefSalad;
            }
            else
            {
                sideCalories = noChoice;
                ViewData["side"] = noChoice;
            }

            if (dessert == 1)
            {
                dessertCalories = applePie;
                ViewData["dessert"] = applePie;
            }
            else if (dessert == 2)
            {
                dessertCalories = sundae;
                ViewData["dessert"] = sundae;
            }
            else if (dessert == 3)
            {
                dessertCalories = fruitCup;
                ViewData["dessert"] = fruitCup;
            }
            else
            {
                dessertCalories = noChoice;
                ViewData["dessert"] = noChoice;
            }

            totalCalories = burgerCalories + drinkCalories + sideCalories + dessertCalories;
            message = "Your total calorie count is " + totalCalories.ToString();

            ViewData["customerName"] = customerName;
            ViewData["message"] = message;

            return View();
        }
    }
}