using System;

namespace RecursionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SumArr(5);
            
        }


        public int SumArr(int end){
            int sum = 0;
            for(int i = 1; i <= end; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            return sum;
        }
    }
}
