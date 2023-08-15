double calculatePrice(double sellingPrice, double salesTax = 0.08)
{
    return sellingPrice * (1 + salesTax);
}

var netPrice =  calculatePrice(100);

Console.WriteLine(netPrice);

var netPrice2 = calculatePrice(100, 0.1);

Console.WriteLine($"The net price is {netPrice2:0.##}");