using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Quantity
    {
        public int ID { get; set; }
        /// <summary>
        /// Blla blla blla
        /// </summary>
        public double Amount{ get; set; }
        public string Unit { get; set; }
        public Quantity(double amount, string unit) 
        {
            Amount = amount;
            Unit = unit;
        }
    }
}