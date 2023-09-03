namespace Single_Responsibility_Principle
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

            InvoideRepository invoideRepository = new InvoideRepository();
            invoideRepository.Save(invoice);
        }
    }

    public class InvoideRepository
    {
        public void Save(Invoice invoice)
        {
            Console.WriteLine($"Saved the invoice #{invoice.InvoiceNo}");
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


}