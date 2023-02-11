using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Barcode { get; set; }
        public double Price { get; set; }
        public string MadeIn { get; set; }
        public Quantity Quantity { get; set; }
        public DateTime ProdDate { get; set; }
        public DateTime DueUsageDate { get; set; }

        DateTime x;
        public DateTime X
        {
            get { return x; }
            set 
            { 
                if (value > DateTime.Now)
                {
                    throw new Exception("Data e prodhimit nuk mund te jete ne te ardhmen. Sistemi ka anuluar krijimin e kesaj instance.");
                }
                else
                {
                    x = value;
                }
            }
        }
    }
}