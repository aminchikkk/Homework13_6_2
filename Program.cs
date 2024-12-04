using System.Diagnostics;

namespace Homework13_6_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Stopwatch stopwatch = new();
            LinkedList<int> LinkedList = new();
            List<int> List = new();

            for (int i = 0; i < 40; i++)
            {
                LinkedList.AddLast(i);
                List.Add(i);
            }
            var element = LinkedList.Find(20);
            stopwatch.Start();
            LinkedList.AddAfter(element, 60);
            stopwatch.Stop();
            Console.WriteLine("Время на добавление элемента в середину LinkedList - " + stopwatch.Elapsed);
            stopwatch.Reset();
            stopwatch.Start();
            List.Insert((List.Count / 2), 60);
            stopwatch.Stop();
            Console.WriteLine("Время на добавление элемента в середину List - " + stopwatch.Elapsed);
        }
    }
}