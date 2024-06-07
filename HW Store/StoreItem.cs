using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Store
{
    public class StoreItem:IStoreItem
    {
        public int ID {  get; set; }
        public decimal Price {  get; set; }
        public StoreItem(int id, decimal price)
        {
            ID = id;
            Price=price;
        }
    }
}
