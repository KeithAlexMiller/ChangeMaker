using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling the function with $4.19.  
            //Notice that when using the decimal format you must end numbers with an 'm'
            ChangeAmount(4.17m);
            Console.ReadKey();
        }

        public static Change ChangeAmount(decimal amount)
        {
            //this is our object that will hold the data of how many coins of each type to return
            Change amountAsChange = new Change();

            //track temp amount as coins are collected
            decimal tempAmount = amount;

            //check if tempAmount has at least $0.25
            while (tempAmount >= 0.25m)
            {
                //add 1 quarter
                amountAsChange.Quarters++;

                //subtract $0.25 from tempAmount
                tempAmount -= 0.25m;
            }

            //check if tempAmount has at least $0.10
            while (tempAmount >= 0.10m)
            {
                //add 1 dime
                amountAsChange.Dimes++;

                //subtract $0.10 from tempAmount
                tempAmount -= 0.10m;
            }

            //check if tempAmount has at least $0.05
            while (tempAmount >= 0.05m)
            {
                //add 1 nickel
                amountAsChange.Nickles++;

                //subtract $0.05
                tempAmount -= 0.05m;
            }

            //check if tempAmount has at least $0.01
            while (tempAmount >= 0.01m)
            {
                //add 1 penny
                amountAsChange.Pennies++;

                //subtract $0.01
                tempAmount -= 0.01m;
            }

            //TODO: Fill in the the code to make this function work
            Console.WriteLine("Amount: $" + amount);
            Console.WriteLine("Quarters: " + amountAsChange.Quarters);
            Console.WriteLine("Dimes: " + amountAsChange.Dimes);
            Console.WriteLine("Nickels: " + amountAsChange.Nickles);
            Console.WriteLine("Pennies: " + amountAsChange.Pennies);

            //return our Change Object
            return amountAsChange;
        }

        /// <summary>
        /// Example using the Change class to store data
        /// </summary>
        public static Change Example(decimal amount)
        {
            //creating a new object of our class Change
            Change amountAsChange = new Change();

            //increasing the number of quarters
            amountAsChange.Quarters++;
            amountAsChange.Quarters += 1;
            amountAsChange.Quarters = amountAsChange.Quarters + 1;


            //outputting to the console
            Console.WriteLine("Quarters: " + amountAsChange.Quarters);

            //returning the object
            return amountAsChange;
        }

    }

    public class Change
    {
        /// <summary>
        /// This is property to hold the number of Quarters to be returned as change
        /// </summary>
        public int Quarters
        {
            get;
            set;
        }

        /// <summary>
        /// This is property to hold the number of Dimes to be returned as change
        /// </summary>
        public int Dimes
        {
            get;
            set;
        }

        /// <summary>
        /// This is property to hold the number of Nickles to be returned as change
        /// </summary>
        public int Nickles
        {
            get;
            set;
        }

        /// <summary>
        /// This is property to hold the number of Pennies to be returned as change
        /// </summary>public int Nickles { get; set; }
        public int Pennies
        {
            get;
            set;
        }

        /// <summary>
        /// This is a constructor, it initializes a new instance of the class (called an object).  This sets it's default values.
        /// </summary>
        public Change()
        {
            this.Quarters = 0;
            this.Dimes = 0;
            this.Nickles = 0;
            this.Pennies = 0;
        }
    }
}
