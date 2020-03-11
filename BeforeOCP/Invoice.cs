using static BeforeOCP.Enums;

namespace BeforeOCP
{
    /* The problem is that if we want to add another new invoice type, then we need to add one more “if” condition in the same 
    “GetInvoiceDiscount” method, in other words, we need to modify the Invoice class. If we are changing the Invoice class again
    and again then we need to ensure that the previous functionalities along with the new functionalities are working properly 
    by testing both the functionalities again.This is because we need to ensure that the existing client’s, which are referencing
    to this class is working properly as expected or not.*/
    public class Invoice
    {
        public double GetInvoiceDiscount(double amount, InvoiceType invoiceType)
        {
            double finalAmount = 0;
            if (invoiceType == InvoiceType.FinalInvoice)
            {
                finalAmount = amount - 100;
            }
            else if (invoiceType == InvoiceType.ProposedInvoice)
            {
                finalAmount = amount - 50;
            }
            return finalAmount;
        }
    }
}
