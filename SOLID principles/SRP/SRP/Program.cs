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
    public Book book;
    public int quantity;
    public double discountRate;
    public double taxRate;
    public double Total
    {
        get
        {
            double price = ((book.Price - book.Price * discountRate) * this.quantity);
            return price * (1 + taxRate);
        }
    }

    public Invoice(Book book, int quantity, double discountRate, double taxRate)
    {
        this.book = book;
        this.quantity = quantity;
        this.discountRate = discountRate;
        this.taxRate = taxRate;
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
        Console.WriteLine(invoice.quantity + "x " + invoice.book.Name + " " + invoice.book.Price + " $");
        Console.WriteLine("Discount Rate: " + invoice.discountRate);
        Console.WriteLine("Tax Rate: " + invoice.taxRate);
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