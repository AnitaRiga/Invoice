namespace Goods
{
    //Public properties of a class.
    public class Goods
    {
        public string partNumber;
        public string partDescription;
        public int countOfPurchasedGoods;
        public string unitOfGoods;
        public decimal unitPrice;

        public Goods(string partNumber, string partDescription, int countOfPurchasedGoods, string unitOfGoods, decimal unitPrice)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            CountOfPurchasedGoods = (countOfPurchasedGoods >= 0) ? countOfPurchasedGoods : 0;
            UnitOfGoods = unitOfGoods;
            UnitPrice = (unitPrice >= 0) ? unitPrice : 0; //if (unitPrice >= 0) then unitPrice, otherwise 0
        }

        public string PartNumber { get; set; }
        public string PartDescription { get; set; }
        public int CountOfPurchasedGoods { get; set; }
        public string UnitOfGoods { get; set; }
        public decimal UnitPrice { get; set; }
    }
}