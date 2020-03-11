using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterOCP
{
    class RecurringInvoice : IInvoice
    {
        public double GetInvoiceDiscount(double amount)
        {
            return amount - 30;
        }
    }
}
