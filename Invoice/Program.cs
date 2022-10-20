namespace Invoice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the Logic Class.
            Logic logic = new Logic();

            // Create an object of the Invoice Class.
            Invoice[] invoices = new Invoice[6];

            //Set Invoice properties.
            invoices[0] = new Invoice("A1", "Nails", 5, "boxes", 7.5M);
            invoices[1] = new Invoice("B2", "Busket", 6, "pcs", 12);
            invoices[2] = new Invoice("F5", "Mug", 21, "pcs", 9);
            invoices[3] = new Invoice("D4", "Building Sand", 8, "packs", 19.8M);
            invoices[4] = new Invoice("E5", "Ladder", 10, "pcs", 85);
            invoices[5] = new Invoice("C3", "Carpet Shampoo", 17, "bottles", 3.45M);

            List<decimal> listOfAmounts = new List<decimal>();

            foreach (var invoice in invoices)
            {
                decimal sum = logic.GetInvoiceAmount(invoice);

                listOfAmounts.Add(sum);

                Console.WriteLine(logic.GetInfoAboutPurchasedGoods(invoice));
            }

            Console.WriteLine();

            Console.WriteLine("Values of invoices:");
            listOfAmounts.ForEach(sum => Console.Write(sum + "\t"));

            Console.WriteLine();

            decimal totalAmount = listOfAmounts.Sum(sum => sum);
            Console.WriteLine($"The Total Amount of the invoices is {totalAmount} euro.");
        }
    }
}



