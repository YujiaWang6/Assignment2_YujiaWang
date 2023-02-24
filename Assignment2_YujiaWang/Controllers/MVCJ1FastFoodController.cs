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
        ///                                                                                                                Your burger choice is: 4
        ///                                                                                                                Your drink choice is: 4
        ///                                                                                                                Your side choice is: 4
        ///                                                                                                                Your dessert choice is: 4  </example>
        /// <example>GET:localhost:xxxxx/MVCJ1FastFood/caloriesCal?customerName=Yujia&burger=1&drink=2&side=3&dessert=4  -> Hello, Yujia. Your total calorie count is 691  </example>
        ///                                                                                                                 Your burger choice is: 1
        ///                                                                                                                 Your drink choice is: 2
        ///                                                                                                                 Your side choice is: 3
        ///                                                                                                                 Your dessert choice is: 4  </example>



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
            J1FastFoodController controller = new J1FastFoodController();
            ViewBag.CustomerName = customerName;
            ViewBag.Message = controller.Menu(burger, drink,side, dessert);
            ViewBag.burger = burger;
            ViewBag.drink = drink;
            ViewBag.side = side;
            ViewBag.dessert = dessert;

            return View();
        }
    }
}