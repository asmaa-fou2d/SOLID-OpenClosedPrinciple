using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AfterOCP.Enums;

namespace AfterOCP
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

            IInvoice invoice;
            double finalAmount = 0;
            if (invoiceType == InvoiceType.FinalInvoice)
            {
                invoice = new ProposedInvoice();
                finalAmount = invoice.GetInvoiceDiscount(amount);
            }
            else if (invoiceType == InvoiceType.ProposedInvoice)
            {
                invoice = new ProposedInvoice();
                finalAmount = invoice.GetInvoiceDiscount(amount);
            }
            else if (invoiceType == InvoiceType.RecurringInvoice)
            {
                invoice = new RecurringInvoice();
                finalAmount = invoice.GetInvoiceDiscount(amount);
            }

            Console.WriteLine("Your final amount after discount is " + finalAmount);
        }
    }
}
