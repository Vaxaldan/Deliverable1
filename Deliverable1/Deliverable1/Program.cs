namespace Deliverable1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stockSoda = 100;
            int restockSoda = 40;
            Console.Write("How many sodas have been sold today? " + stockSoda + " in stock.\n");
            int soldSoda = int.Parse(Console.ReadLine());
            stockSoda -= soldSoda;

            if (stockSoda > 100)
            {
                Console.WriteLine("Invalid sold ammount, please double check stock!\n");
            }
            else if (stockSoda == 100)
            {
                Console.WriteLine("There are " + stockSoda + " soda, do not order more!\n");
            }
            else if (stockSoda > 100)
            {
                Console.WriteLine("There are " + stockSoda + " soda please double check stock and do not order more!\n");
            }
            else if (stockSoda < 99 && stockSoda > 41)
            {
                Console.WriteLine("There are " + stockSoda + " soda. Do not order more!\n");
            }
            else if (stockSoda <= restockSoda)
            {
                Console.WriteLine("There are " + stockSoda + " soda, please order more!\n");
            }

            int stockChip = 40;
            int restockChip = 20;
            Console.Write("How many chips were sold today? " + stockChip + " in stock.\n");
            int soldChip = int.Parse(Console.ReadLine());
            stockChip -= soldChip;

            if (stockChip > 40)
            {
                Console.WriteLine("Invalid sold ammount, please double check stock!\n");
            }
            else if (stockChip == 40)
            {
                Console.WriteLine("There are " + stockChip + " chips, plese do not order more!\n");
            }
            else if (stockChip > 40)
            {
                Console.WriteLine("There are " + stockChip + " chips, please double check stock and do not order more!\n");
            }
            else if (stockChip < 40 && stockChip > 20)
            {
                Console.WriteLine("There are " + stockChip + " chips, please do not order more!\n");
            }
            else if (stockChip <= restockChip)
            {
                Console.WriteLine("There are " + stockChip + " chips, please order more!\n");
            }

            int stockCandy = 60;
            int restockCandy = 40;
            Console.Write("How much candy was sold today? " + stockCandy + " in stock.\n");
            int soldCandy = int.Parse(Console.ReadLine());
            stockCandy -= soldCandy;

            if (stockCandy > 60)
            {
                Console.WriteLine("Invalid sold ammount, please double check stock!\n");
            }
            else if (stockCandy == 60)
            {
                Console.WriteLine("There is " + stockCandy + " candy, please do not order more!\n");
            }
            else if (stockCandy > 60)
            {
                Console.WriteLine("There is " + stockCandy + " candy, please double check stock and do not order more!\n");
            }
            else if (stockCandy < 60 && stockCandy > 40)
            {
                Console.WriteLine("There is " + stockCandy + " candy, please do not order more!\n");
            }
            else if (stockCandy <= restockCandy)
            {
                Console.WriteLine("There is " + stockCandy + " candy, please order more!\n");
            }
        }
        }
    }