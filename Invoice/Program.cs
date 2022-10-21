namespace Goods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the Logic Class.
            InvoicingDepartment  invoicingDepartment = new InvoicingDepartment();

            // Create an object of the Goods Class.
            Goods[] goods = new Goods[6];

            //Set Goods properties.
            goods[0] = new Goods("A1", "Nails", 5, "boxes", 7.5M);
            goods[1] = new Goods("B2", "Busket", 6, "pcs", 12);
            goods[2] = new Goods("F5", "Mug", 21, "pcs", 9);
            goods[3] = new Goods("D4", "Building Sand", 8, "packs", 19.8M);
            goods[4] = new Goods("E5", "Ladder", 10, "pcs", 85);
            goods[5] = new Goods("C3", "Carpet Shampoo", 17, "bottles", 3.45M);

            List<decimal> listOfAmounts = new List<decimal>();

            foreach (var item in goods)
            {
                decimal sum = invoicingDepartment.GetInvoiceAmount(item);

                listOfAmounts.Add(sum);

                Console.WriteLine(invoicingDepartment.GetInfoAboutPurchasedGoods(item));
            }

            Console.WriteLine();

            Console.WriteLine("Values of goods:");
            listOfAmounts.ForEach(sum => Console.Write(sum + "\t"));

            Console.WriteLine();

            decimal totalAmount = listOfAmounts.Sum(sum => sum);
            Console.WriteLine($"The Total Amount of the goods is {totalAmount} euro.");
        }
    }
}
