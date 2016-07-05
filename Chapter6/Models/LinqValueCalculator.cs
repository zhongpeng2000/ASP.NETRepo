using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chapter6.Models
{
    public class LinqValueCalculator : ILinqValueCalculator
    {
        //public  decimal ValueProducts(IEnumerable<Product > product)
        //{
        //    return product.Sum(x => x.Price);
        //}

        private IDiscountHelper discounter;
        private static int counter = 0;

        public LinqValueCalculator(IDiscountHelper discounterParam)
        {
            discounter = discounterParam;
            System.Diagnostics.Debug.WriteLine(string.Format("Instance {0} created", ++counter));
        }


        public decimal ValueProducts(IEnumerable<Product> product)
        {
            return discounter.ApplyDiscount(product.Sum(prop => prop.Price));
        }
    }
}