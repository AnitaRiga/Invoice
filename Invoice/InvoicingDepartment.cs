namespace Goods
{
    public class InvoicingDepartment
    {
        public string GetInfoAboutPurchasedGoods(Goods goods)
        {
            return "UPC: " + goods.PartNumber +
              ", Product Description: " + goods.PartDescription +
              ", QTY: " + goods.CountOfPurchasedGoods + " " + goods.UnitOfGoods +
              ", Amount: " + GetInvoiceAmount(goods) + " euro.";
        }

        public decimal GetInvoiceAmount(Goods goods)
        {
            decimal sum = goods.CountOfPurchasedGoods * goods.UnitPrice;
            return sum;
        }
    }
}