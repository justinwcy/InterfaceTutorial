using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingModel.Interfaces;

namespace ShoppingModel
{
    public class CourseProductModel : ICourseProductModel
    {
        public string ProductName { get; set; }
        public bool HasShippedToBuyer { get; set; }
        public double Price { get; set; }
        public void ShipToCustomer(ICustomerModel customer)
        {
            Console.WriteLine($"{ProductName} has been sent to {customer.FirstName} {customer.LastName}");
            HasShippedToBuyer = true;
        }

        public List<string> Lessons { get; set; }
        public void ShowLessons()
        {
            Console.WriteLine(string.Join(", ",Lessons));
        }
    }
}
