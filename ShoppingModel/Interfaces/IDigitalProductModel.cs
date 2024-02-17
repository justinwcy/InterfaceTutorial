using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingModel.Interfaces
{
    public interface IDigitalProductModel : IProductModel
    {
        int DownloadsLeft { get; set; }
    }
}
