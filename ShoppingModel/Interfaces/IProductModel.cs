using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingModel.Interfaces
{
    public interface IProductModel
    {
        string ProductName { get; set; }
        bool HasShippedToBuyer { get; }
        double Price { get; set; }
        void ShipToCustomer(ICustomerModel  customer);

    }
}
