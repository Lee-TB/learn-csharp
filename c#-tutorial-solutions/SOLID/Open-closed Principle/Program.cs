namespace Open_closed_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice()
            {
                InvoiceNo = 1,
                Customer = "John Doe",
                IssuedDate = new DateOnly(2023, 4, 1),
                Description = "Website Design",
                Amount = 1000
            };

            IInvoiceRepository repo = new FileInvoiceRepository();
            repo.Save(invoice);

            repo = new DBInvoiceRepository();
            repo.Save(invoice);

            repo = new JSONInvoiceRepository();
            repo.Save(invoice);
        }


    }

    public class Invoice
    {
        public int InvoiceNo { get; set; }
        public DateOnly IssuedDate { get; set; }
        public string? Customer { get; set; }
        public decimal Amount { get; set; }
        public string? Description { get; set; }
    }

    interface IInvoiceRepository
    {
        void Save(Invoice invoice);
    }

    class FileInvoiceRepository : IInvoiceRepository
    {
        public void Save(Invoice invoice)
        {
            Console.WriteLine($"Saved the invoice #{invoice.InvoiceNo} into a file.");
        }
    }

    class DBInvoiceRepository : IInvoiceRepository
    {
        public void Save(Invoice invoice)
        {
            Console.WriteLine($"Saved the invoice #{invoice.InvoiceNo} into the database.");
        }
    }

    class JSONInvoiceRepository : IInvoiceRepository
    {
        public void Save(Invoice invoice)
        {
            Console.WriteLine($"Saved the invoice #{invoice.InvoiceNo} into the database.");
        }
    }
}