namespace SRP;

internal class Violate
{
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
        private Book book;
        private int quantity;
        private double discountRate;
        private double taxRate;
        private double Total
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

        public void printInvoice()
        {

        }

        public void saveToFile(String filename)
        {
            // Creates a file with given name and writes the invoice
        }
    }
}
