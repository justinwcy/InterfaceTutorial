using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingModel.Interfaces
{
    public interface ICustomerModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string Address { get; set; }
    }
}
