using Warehouse;

Item chocolate = new Item("chocolate", 0.8m);

Shop theShop = new Shop("Fry's Chocolate");

theShop.AddToShop(chocolate, 100);


foreach (Stock item in theShop.StockList)
{
    Console.WriteLine(item.Item.Name);
}
