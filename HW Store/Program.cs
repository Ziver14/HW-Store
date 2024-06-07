namespace HW_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inventory = new StoreInventory();

            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                var item = new StoreItem(i, (decimal)random.NextDouble() * 100);
                inventory.AddItem(item);
            }

            inventory.PrintAllItems();
            Console.WriteLine();
            // Поиск товаров по цене
            var expensiveItems = inventory.GetAllItems().Where(i => i.Price > 50).OrderByDescending(i => i.Price);
            Console.WriteLine("Expensive items:");
            foreach (var item in expensiveItems)
            {
                Console.WriteLine($"Item ID: {item.ID}, Price: {item.Price:C}");
            }
            Console.WriteLine();
            //Изменение цены товара
            var itemToUpdate = inventory.FindItem(5);
            itemToUpdate.Price = 75.99m;
            Console.WriteLine($"Цена товара {itemToUpdate.ID} изменена, новая цена: {itemToUpdate.Price:C}");
            Console.WriteLine();
            //// Отчет, группирующий товары по ценовым диапазонам
            var priceRangeReport = inventory.GetAllItems()
                .GroupBy(i => (int)(i.Price / 10) * 10)
                .Select(g => new { PriceRange = $"{g.Key} - {g.Key + 9:C}", Count = g.Count() });
            foreach (var item in priceRangeReport)
            {
                Console.WriteLine($"Товаров в диапазоне: {item.PriceRange}, Кол-во товаров: {item.Count}");
            }


        }
        
    }

}
    

