using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingModel.Interfaces;

namespace ShoppingModel
{
    public class ProductModel : IProductModel
    {
        public string ProductName { get; set; }
        public bool HasShippedToBuyer { get; set; }
        public double Price { get; set; }
        public void ShipToCustomer(ICustomerModel customer)
        {
            Console.WriteLine($"{ProductName} has been shipped to " +
                              $"{customer.FirstName} {customer.LastName} at {customer.Address}");
            HasShippedToBuyer = true;
        }

    }
}
