using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01655606_Ashim_Shrestha.Controllers
{
    public class Assignment1Controller : ApiController
    {
        // Question 1

        /// <summary>
        /// Returning 10 more than the integer input
        /// </summary>
        /// <param name="number">Any integer value (+ve/-ve)</param>
        /// <returns>
        /// An integer value obtained after the addition of 10 to the input number
        /// </returns>
        /// 
        
        // Defining the route and the HTTP request type for the method
        [Route("api/Assignment1/AddTen/{number}")]
        [HttpGet]
        // The number input is passed as the parameter for the method
        public int Question1 (int number)
        {
            // Returning the number with 10 added to it
            return number + 10;
        }


        // Question 2

        /// <summary>
        /// Returning the square of the integer input
        /// </summary>
        /// <param name="number">The integer input</param>
        /// <returns>
        /// An integer number that is the squared value of the input integer
        /// </returns>
        /// 

        // Defining the route and the HTTP request type for the method
        [Route("api/Assignment1/Square/{number}")]
        [HttpGet]
        // The number input is passed as the parameter for the method
        public int Question2(int number)
        {
            // Returning the absolute integer squared value 
            return Math.Abs(number * number);
        }


        // Question 3

        /// <summary>
        /// Returning the string "Hello World" using POST HTTP request
        /// </summary>
        /// <returns>
        /// The string "Hello World"
        /// To see the result, in cmd : curl -d "" http://localhost:58080/api/Assignment1/Greeting
        /// </returns>
        /// 

        // Defining the route and HTTP request type for the method
        [Route("api/Assignment1/Greeting")]
        [HttpPost]
        // No parameter is passed for POST request
        public string Question3()
        {
            // Returning the string
            return "Hello World!";
        }


        // Question 4

        /// <summary>
        /// Returning the string with the integer input value
        /// </summary>
        /// <param name="number">The integer input value representing the total number of people</param>
        /// <returns>
        /// The input integer value concatenated with the provided string
        /// </returns>
        /// 

        // Defining the route and HTTP request type for the method
        [Route("api/Assignment1/Greeting2/{number}")]
        [HttpGet]
        // Passing the integer input number as the parameter
        public string Question4(int number)
        {
            // Returning the inyeger input value with the provided string (concat)
            return "Greetings to " + number + " people!";
        }






        // Question 5 - 4 mathematical operations


        // Question 5 - remainder

        /// <summary>
        /// Method to return the remainder
        /// </summary>
        /// <param name="number1">The number to be divided</param>
        /// <param name="number2">The divider</param>
        /// <returns>
        /// A string with the remainder value 
        /// </returns>
        /// 

        // Defining the route and HTTP request type where the route takes 2 placeholders
        [Route("api/Assignment1/NumberMachine/remainder/{number1}/{number2}")]
        [HttpGet]
        // Method that returns a string and takes in 2 parameters
        public string Question5R(int number1, int number2)
        {
            // Storing the remainder in a new variable
            int remainder = number1 % number2;
            // Returning the remainder with a string text
            return "The remainder is " + remainder.ToString();
        }


        // Question 5 - multiplication

        /// <summary>
        /// A method to return the multiplied value between 2 integers
        /// </summary>
        /// <param name="number1">The first number</param>
        /// <param name="number2">The second number</param>
        /// <returns>
        /// A string with the multiplied value of the two numbers
        /// </returns>
        /// 

        // Defining the route and HTTP request type for the method
        [Route("api/Assignment1/NumberMachine/multiplication/{number1}/{number2}")]
        [HttpGet]
        // Method that returns a string and takes 2 parameters
        public string Question5M(int number1, int number2)
        {
            // Storing the multiplied value of the numbers in a new variable
            int multiplication = number1 * number2;
            // Returning a string text with the multiplied value
            return "The multiplication value is " + multiplication.ToString();
        }


        // Question 5 - sine

        /// <summary>
        /// Method to return the ratio of 2 sides of a right angled triangle
        /// </summary>
        /// <param name="number1">Integer degree value</param>
        /// <returns>
        /// The sine value of the number entered as degree
        /// </returns>
        [Route("api/Assignment1/NumberMachine/sine/{number1}")]
        [HttpGet]
        public string Question5S(int number1)
        {
            // Converting degree into radian
            double rad = number1 * (Math.PI / 180);
            // Calculating the sin value using Sin function
            double sinV = Math.Sin(rad);

            // Returning the sin value as string
            return "The sine of the number is " + sinV.ToString();
        }


        // Question 5 - natural logarithm of a number

        /// <summary>
        /// A method to return the natural logarithm of a number
        /// </summary>
        /// <param name="angle">The number/angle input</param>
        /// <returns>
        /// A string text with the logarithm value
        /// </returns>
        /// 

        // Defining the route and the HTTP method
        [Route("api/Assignment1/NumberMachine/log/{angle}")]
        [HttpGet]
        // Function that return a string value and takes in a floating point value as parameter
        public string Question5(float angle)
        {
            // Logic to calculate the logarithm of the provided angle and storing in a new variable
            double Log = Math.Log(angle + Math.Sqrt(angle * angle + 1));
            // Returning a string text with the logarithm value
            return "The logarithm of the number is " + Log.ToString();
        }
    }
}
