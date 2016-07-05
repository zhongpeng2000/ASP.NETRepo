using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6.Models
{
    public interface ILinqValueCalculator
    {
        decimal ValueProducts(IEnumerable<Product> products);
    }
}
