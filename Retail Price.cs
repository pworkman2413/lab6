
double price;
Console.WriteLine("What was the price of your item in dollars?");
price = Convert.ToInt32(Console.ReadLine());

double markup;
Console.WriteLine("What was the markup of your item in percent?");
markup = Convert.ToInt32(Console.ReadLine());


static double calculateRetail(double price,double markup)
{
    double total = price * (markup / 100);
    total = total + price;
    return total;
}

Console.WriteLine($"The price was {price} dollars, with a {markup} percent markup. making your total {calculateRetail(price,markup)} dollars)");