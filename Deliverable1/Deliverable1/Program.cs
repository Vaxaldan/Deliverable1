namespace Deliverable1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please eneter the values of total units sold below.");

            Console.Write("How many sodas have been sold today? 100 in stock.");
            int soldSoda = int.Parse(Console.ReadLine());
            int stockSoda = 100;
            int totalSoda = (stockSoda - soldSoda);
            if (soldSoda > 100)
            {
                Console.WriteLine("Value to high, please double check stock. Stock not adjusted.");
            }
            else if (soldSoda <= 100)
            {
                Console.WriteLine("There is " + totalSoda + " soda left in stock.");
            }

            Console.Write("How many chips were sold today? 40 in stock. ");
            int soldChip = int.Parse(Console.ReadLine());
            int stockChip = 40;
            int totalChip = (stockChip - soldChip);
            if (soldChip > 40)
            {
                Console.WriteLine("Value to high, please double check stock. Stock not adjusted.");
            }
            else if (soldChip <= 40)
            {
                Console.WriteLine("There are " + totalChip + " chips left in stock");
            }


            Console.Write("How much candy was sold today? 60 in stock.");
            int soldCandy = int.Parse(Console.ReadLine());
            int stockCandy = 60;
            int totalCandy = (stockCandy - soldCandy);
            if (soldCandy > 60)
            {
                Console.WriteLine("Value to high, please double check stock. Stock not adjusted.");
            }
            else if (soldCandy <= 60)
            {
                Console.WriteLine("There are " + totalCandy + " candy left in stock");
            }

            Console.WriteLine("Thank you for filling out the stock! Below is a list of what needs ordered!");
            if (totalSoda <= 40)
            {
                Console.WriteLine("Please order more soda. ");
            }


            if (totalChip <= 20)
            {
                Console.WriteLine("Please order more chips. ");
            }
            if (totalCandy <= 40)
            {
                Console.WriteLine("Please order more candy. ");
            }   
        }
    }
}