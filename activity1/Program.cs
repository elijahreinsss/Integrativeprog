using System.Transactions;

namespace activity1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name : ");
            string name = Console.ReadLine();
            Console.Write("Enter the total number of your enrolled courses  " );
            int enrolledcourses = Convert.ToInt32( Console.ReadLine() );
            Console.Write("Enter the price of your favorite book : ");
          double bookprice = Convert.ToDouble( Console.ReadLine() );

            Console.WriteLine( "Name : " + name);
            Console.WriteLine("Total number of enrolled courses : " +  enrolledcourses);
            Console.WriteLine("Price of Favorite book : " + bookprice);

            Console.WriteLine("\n press any key to exit");
            Console.ReadKey();
              

           


        }
    }
}