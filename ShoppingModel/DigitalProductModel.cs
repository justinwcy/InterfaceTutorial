using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingModel.Interfaces;

namespace ShoppingModel
{
    public class DigitalProductModel:IDigitalProductModel
    {
        public string ProductName { get; set; }
        public bool HasShippedToBuyer { get; set; }
        public double Price { get; set; }
        public void ShipToCustomer(ICustomerModel customer)
        {
            if (DownloadsLeft > 0)
            {
                Console.WriteLine($"{ProductName} has been shipped to " +
                                 $"{customer.FirstName} {customer.LastName} at {customer.Email}");
                
            }
            else
            {
                Console.WriteLine($"{ProductName} is not shipped");
                HasShippedToBuyer = true;
            }

            DownloadsLeft--;
        }

        public int DownloadsLeft { get; set; }
    }
}
