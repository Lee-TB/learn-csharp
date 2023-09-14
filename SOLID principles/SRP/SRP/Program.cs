namespace SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

public class Book
{
    public string ISBN { get; set; }
    public string Name { get; set; }
    public string AuthorName { get; set; }
    public int Year { get; set; }
    public double Price { get; set; }
}

public class Invoice
{
    public Book Book { get; set; }
    public int Quantity { get; set; }
    public double DiscountRate { get; set; }
    public double TaxRate { get; set; }
    public double Total
    {
        get
        {
            double price = ((Book.Price - Book.Price * DiscountRate) * Quantity);
            return price * (1 + TaxRate);
        }
    }

    public Invoice(Book book, int quantity, double discountRate, double taxRate)
    {
        Book = book;
        Quantity = quantity;
        DiscountRate = discountRate;
        TaxRate = taxRate;
    }
}

public class InvoicePrinter
{
    private Invoice invoice;
    public InvoicePrinter(Invoice invoice)
    {
        this.invoice = invoice;
    }
    public void Print()
    {
        Console.WriteLine(invoice.Quantity + "x " + invoice.Book.Name + " " + invoice.Book.Price + " $");
        Console.WriteLine("Discount Rate: " + invoice.DiscountRate);
        Console.WriteLine("Tax Rate: " + invoice.TaxRate);
        Console.WriteLine("Total: " + invoice.Total + " $");
    }
}

public class InvoicePersistence
{
    Invoice invoice;

    public InvoicePersistence(Invoice invoice)
    {
        this.invoice = invoice;
    }

    public void saveToFile(String filename)
    {
        // Creates a file with given name and writes the invoice
    }
}