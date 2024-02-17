using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingModel;
using ShoppingModel.Interfaces;

namespace ShoppingConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer = GetCustomerModel();
            var products = GetProducts();

            foreach (var product in products)
            {
                product.ShipToCustomer(customer);

                if (product is IDigitalProductModel digital)
                {
                    Console.WriteLine($"Downloads left = {digital.DownloadsLeft}");
                }
            }

            Console.ReadLine();
        }

        internal static ICustomerModel GetCustomerModel()
        {
            return new CustomerModel()
            {
                FirstName = "Justin",
                LastName = "Wong",
                Address = "Malaysia",
                Email = "justinwcy96@gmail.com",
                Gender = "Male",
                Id = 1
            };
        }

        internal static List<IProductModel> GetProducts()
        {
            return new List<IProductModel>
            {
                new ProductModel() { ProductName = "Product 1", HasShippedToBuyer = false, Price = 1.23 },
                new DigitalProductModel()
                    { ProductName = "Digital Product 1", HasShippedToBuyer = false, DownloadsLeft = 5, Price = 23 },
                new CourseProductModel() {ProductName = "Course Product 1", HasShippedToBuyer = false, Lessons = new List<string>() {"Lesson 1"}, Price=1.11
            }
            };
        }
    }
}
