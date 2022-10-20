namespace Invoice
{
    public class Logic
    {
        public decimal GetInvoiceAmount(Invoice invoice)
        {
            decimal sum = invoice.CountOfPurchasedGoods * invoice.UnitPrice;
            return sum;
        }

        public string GetInfoAboutPurchasedGoods(Invoice invoice)
        {
            return "UPC: " + invoice.PartNumber +
              ", Product Description: " + invoice.PartDescription +
              ", QTY: " + invoice.CountOfPurchasedGoods + " " + invoice.UnitOfGoods +
              ", Amount: " + GetInvoiceAmount(invoice) + " euro.";
        }
    }
}
