using System;
namespace uppgift_2._3
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad har den första anställda för lön");
            int lön1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Vad har den andra anställda för lön");
            int lön2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Vad har den tredje anställda för lön");
            int lön3 = int.Parse(Console.ReadLine());

            int sum = (lön1 + lön2 + lön3) / 3;
            Console.WriteLine("Medelvärdet av de tre lönerna är" + sum);

        }
    }
}