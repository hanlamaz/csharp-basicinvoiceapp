using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Invoice
    {
        string partNumber;

        public string PartNumber
        {
            get { return partNumber; }
            set { partNumber = value; }
        }
        string partDescription;

        public string PartDescription
        {
            get { return partDescription; }
            set { partDescription = value; }
        }
        int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { if (value >= 0) quantity = value; }
        }
        decimal pricePerItem;

        public decimal PricePerItem
        {
            get { return pricePerItem; }
            set { if (value >= 0) pricePerItem = value; }
        }

        public Invoice(string pNum, string desc, int quantity, decimal price)
        {
            this.PartNumber = pNum;
            this.PartDescription = desc;
            this.Quantity = quantity;
            this.PricePerItem = price;
        }
        public decimal GetInvoiceAmount()
        {
            return PricePerItem * Quantity;
        }
        public void ListInvoice()
        {
            Console.WriteLine("Part Number :"+PartNumber);
            Console.WriteLine("Description :"+PartDescription);
            Console.WriteLine("Quantity :"+Quantity);
            Console.WriteLine("Price Per Item :"+PricePerItem);
            Console.WriteLine("Total Amount :"+GetInvoiceAmount());
        }
    }
}
