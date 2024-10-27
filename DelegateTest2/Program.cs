using System.Runtime.CompilerServices;

namespace DelegateTest2
{
    internal class Program
    {
        
        //static bool IsOdd(int item) 
        //{
        //    return (item % 2 != 0);
        //}
        //static bool IsEven(int item)
        //{
        //    return (item % 2 == 0);
        //}
        static void Main(string[] args)
        {
            // 1.Func
            // 2.Action
            // 3.Predicate

            string str = "Hello World";
            //Func
            Func<char,string> func = str.Trim;
            
            
            int[] array = { 1, 2, 8, 20, 4, -2, 3,5 };
             
            array.Where(x => x % 2 == 0 && x > 0).MakeAction(Console.WriteLine);
            //array.First(x => x % 2 == 0);
            //array.Last(x => x % 2 == 0);
            //array.Any(x => x > 0);
            //array.getElementsByCondition(item =>  item % 2 == 0 && item > 0).MakeAction(x=> Console.WriteLine($"x = {x}"));
        }
    }
}
