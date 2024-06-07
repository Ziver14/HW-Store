using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Store
{
    public class StoreInventory
    {
        private List<StoreItem> items = new List<StoreItem>();
        public void AddItem(StoreItem item)
        {
            if (items.Any(i=>i.ID==item.ID)) 
            {
                throw new ArgumentException($"Товар с таким ID: {item.ID} уже присутствует.");
            }
            items.Add(item);

        }

        public IEnumerable<IStoreItem> PrintAllItems()
        {
            foreach (var item in items)
            {
                Console.WriteLine($"ID товара:{item.ID}, Цена товара {item.Price:C}");
            }
            return items;
        }
        public void RemoveItem(int id) 
        {
            var item = items.FirstOrDefault(i=>i.ID==id);
            if (item == null) 
            {
                throw new ArgumentException($"Товара с таким ID {item.ID} не найдено.");
            }
            items.Remove(item);
        }
        public IStoreItem FindItem(int id)
        {
            var item = items.FirstOrDefault(i=> i.ID==id);
            if (item == null)
            {
                throw new ArgumentException($"Товара с таким ID {item.ID} не найдено.");
            }
            return item;
        }
        public IEnumerable<IStoreItem>GetAllItems() { return items; }

        



    }
}
