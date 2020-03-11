using System;
using static BeforeOCP.Enums;

namespace BeforeOCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter invoice type FinalInvoice or ProposedInvoice");
            var type = Console.ReadLine();
            Enum.TryParse(type, out InvoiceType invoiceType);

            Console.WriteLine("Please enter your amount");
            var amount = double.Parse(Console.ReadLine());

            Invoice invoice = new Invoice();
            var finalAmount = invoice.GetInvoiceDiscount(amount, invoiceType);

            Console.WriteLine("Your final amount after discount is " + finalAmount);

        }
    }
}
