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

        public LinqValueCalculator(IDiscountHelper discounterParam)
        {
            discounter = discounterParam;
        }


        public decimal ValueProducts(IEnumerable<Product> product)
        {
            return discounter.ApplyDiscount(product.Sum(prop => prop.Price));
        }
    }
}