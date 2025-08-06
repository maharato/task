using System.Diagnostics.Metrics;
using System.Numerics;

namespace task
{
    internal class Program
    {
  
        static void Addnums(int num, ref List<int> numbers) {
          
            numbers.Add(num);
        }
        static void shownums( ref List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++) {
                if (numbers.Count == 0) {
                    Console.WriteLine("the list is empty");
                }
                else
                    Console.Write(numbers[i]+" ");
            }
            Console.WriteLine("");
            
        }
        static void mean(ref List<int> numbers)
        {
            //numbers.avg()
            int mean = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
              
                 mean=(mean+numbers[i]);
               
            }
            Console.WriteLine(mean/numbers.Count);
        }
        static void getmax(ref List<int> numbers)
        {
            int max = 0;
            //numbers.max()
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }


            }
            Console.WriteLine(max);
        }
        //numbers.min()
        static void getmin(ref List<int> numbers)
        {
            int min = numbers[0];
               
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] <min)
                {
                    min = numbers[i];
                }


            }
            Console.WriteLine(min);
        }
        static void Main(string[] args)
        {
          List<int> numbers = new List<int>();
            Console.WriteLine("    P - Print numbers\r\n    A - Add a number\r\n    M - Display mean of the numbers\r\n    S - Display the smallest number\r\n    L - Display the largest number\r\n    Q - Quit\r\n");
            Console.WriteLine("please enter your choice");
         
            string s = "";
            while (s !="Q") {
              
                s = Console.ReadLine();
              
                switch (s)
                {
                    case "P":

                        shownums(ref numbers);
                        break;
                    case "A":
                        Console.WriteLine("enter number to be added");
                        int num = Convert.ToInt32(Console.ReadLine());
                   
                        Addnums(num, ref numbers);
                        break;

                    case "M":

                        mean(ref numbers);
                        break;

                    case "S":

                        getmin(ref numbers);
                        break;

                    case "L":

                        getmax(ref numbers);
                        break;

                    default:
                        Console.WriteLine("please enter valid choice");

                        break;


                }
                if (s == "Q")
                {

                    break;
                }
                Console.WriteLine("PLAESE ENTER OTHER COICE");



            }
        }
    }
}
