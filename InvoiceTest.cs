using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class InvoiceTest
    {
        static void Main(string[] args)
        {
            Invoice inv1 = new Invoice("1234ab", "Kürek", 25, 9.22M);
            inv1.ListInvoice();
        }
    }
}
