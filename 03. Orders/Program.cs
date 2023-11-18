//Create a program that keeps the information about products and their prices. Each product has a name, a price and a quantity. If the product doesn't exist yet, add it with its starting quantity.
//If you receive a product, which already exists, increase its quantity by the input quantity and if its price is different, replace the price as well.
//You will receive products' names, prices and quantities on new lines. Until you receive the command "buy", keep adding items. When you do receive the command "buy", print the items with their names and the total price of all the products with that name.
//Input
//•	Until you receive "buy", the products will be coming in the format: "{name} {price} {quantity}".
//•	The product data is always delimited by a single space.
//Output
//•	Print information about each product in the following format: 
//"{productName} -> {totalPrice}"
//•	Format the average grade to the 2nd digit after the decimal separator.


Dictionary<string,List<decimal>> products= new();
string input =Console.ReadLine();
while (input != "buy")
{
    string[] inputArray = input.Split();
    string product = inputArray[0];
    decimal price = decimal.Parse(inputArray[1]);
    decimal quantity = decimal.Parse(inputArray[2]);
    if (!products.ContainsKey(product))
    {
        products.Add(product, new() { price,quantity});


    }
    else
    {
        products[product][0] = price;

        products[product][1] += quantity;
    }
    input = Console.ReadLine();
}
foreach(KeyValuePair< string,List<decimal>> product in products)
{
string currentProductName = product.Key;
    decimal currentPoductPrice = product.Value[0];
    decimal currentPoductQuantity = product.Value[1];
    decimal currentProductAmount = currentPoductPrice * currentPoductQuantity;
    Console.WriteLine($"{currentProductName} -> {currentProductAmount:f2}");
}