internal class currency
{
    private static void Main(string[] args)
    {
        do
        {

            Console.WriteLine("Convertion According to Black Market");
            Console.WriteLine("----------------------------------------------");
            Console.Write("Enter value Amount:");
            double Amount = Convert.ToDouble(Console.ReadLine());
            //double Dollar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("select conversion direction");
            Console.WriteLine("1:Dollar to Naira");
            Console.WriteLine("2:Naira to Dollar");
            Console.WriteLine("3:Naira to Euro");
            Console.WriteLine("4:Euro to Dollar");
            Console.WriteLine("5:Euro to Naira");
            Console.WriteLine("6:Dollar to Euro");
            Console.WriteLine("Enter selection 1,2,3,4,5,6");
            int selection = Convert.ToInt32(Console.ReadLine());
            double convertedAmount = 0;
            //double convertNairatoDollar = 0;
            if (selection == 1)
            {
                convertedAmount = (Amount * 920);

                Console.WriteLine("The currency has been converted to Naira:N" + convertedAmount);
            }
            else if (selection == 2)
            {
                convertedAmount = (Amount / 920);
                Console.WriteLine("The currency has been converted to Dollars:$" + convertedAmount);

            }
            else if (selection == 3)
            {
                convertedAmount = (Amount / 980);
                Console.WriteLine("The currency has been converted to Naira:N" + convertedAmount);

            }
            else if (selection == 4)
            {
                convertedAmount = (Amount / 1.07);
                Console.WriteLine("The currency has been converted to Euro:E" + convertedAmount);

            }
            else if (selection == 5)
            {
                convertedAmount = (Amount * 980);
                Console.WriteLine("The currency has been converted to Naira:N" + convertedAmount);

            }

            else if (selection == 6)
            {
                convertedAmount = (Amount * 1.07);
                Console.WriteLine("The currency has been converted to Euro:E" + convertedAmount);

            }

            else
            {
                Console.WriteLine("Invalid selction");
            }
            Console.Write("Would you like to perform another convertion?(Y=yes,N=No):");

           
        } while (Console.ReadLine().ToUpper() == "Y");
        
       
        
        Console.WriteLine("see ya!");
          

          Console.ReadKey();


    }   
}
