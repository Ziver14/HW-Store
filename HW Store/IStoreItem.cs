using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Store
{
    public interface IStoreItem
    {
        int ID { get; set; }
        decimal Price {  get; set; }

    }
}
