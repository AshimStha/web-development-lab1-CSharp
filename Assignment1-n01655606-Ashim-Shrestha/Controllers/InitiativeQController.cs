using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01655606_Ashim_Shrestha.Controllers
{
    public class InitiativeQController : ApiController
    {
        /// <summary>
        /// A function that takes in the number of days and gives the cost for every fortnight including the tax
        /// </summary>
        /// <param name="days">The total number of days</param>
        /// <returns>
        /// String with the total price after tax 
        /// </returns>
        /// 

        // setting the route and the http request type for the method
        [Route("api/assignment1/initiative/HostingCost/{days}")]
        [HttpGet]

        // method to get the total cost of hosting
        public string getHostingCost (int days)
        {
            // storing the total hosting charge per fortnight (14 days)
            double charge = 5.50;
            // storing the tax percentage
            double HST = 0.13;
            // the total number of FNs
            double totalFN = days / 14;

            // calculating the total costs
            double totalFNCost = totalFN * charge;

            // calculating the total HST 
            double totalHST = totalFNCost * HST;
            // calculating the final price with tax
            double grandTotal = totalFNCost + totalHST;

            // returning the total price detail along with the final price after tax
            return ("\"" + days + " fortnights at $5.50/FN = $" + totalFNCost + " CAD\"\n\"HST 13% = $" + totalHST + " CAD\"\n\"Total = $" + grandTotal + " CAD\"");
        }
    }
}
