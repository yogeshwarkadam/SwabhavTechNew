using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericQueueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Iqueue<int> num = new MyQueue<int>();
            num.Enque(100);
            num.Enque(200);
            num.Enque(300);
            num.Enque(400);

            Part1(num);
            Part2(num);
           
        }
        private static void Part2(Iqueue<int> numbers)
        {
            iterateUsingFor(numbers);
            iterateWithoutUsingFor(numbers);
        }

        private static void iterateWithoutUsingFor(Iqueue<int> numbers)
        {
            Console.WriteLine("Iterate without using for loop");
            IEnumerator<int> iterator = numbers.GetEnumerator();
            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current);
            }
        }

        private static void iterateUsingFor(Iqueue<int> numbers)
        {
            Console.WriteLine("Iterate using For loop");
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
        }

        private static void iteratUsingFor(Iqueue<int> numbers)
        {
            foreach (int iterator in numbers)
            {
                Console.WriteLine(iterator);
            }
        }
        private static void Part1(Iqueue<int> num)
        {
            Console.WriteLine("Count : " + num.Count());
            Console.WriteLine("Deque : " + num.Deque());
            Console.WriteLine("Count after deque operation : " + num.Count());
        }
       
    }
}
