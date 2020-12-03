using System;

namespace LineComparisonProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("if get 0:(both are equal),if get 1:(length 1 is grater than length2)," +
            "if get -1:(length 1 is lesser than length2) :: "+program.computeMethode());
        }
        public int computeMethode()
        {
            int length1 = 0, length2 = 0;
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("input for two lines= " + i);
                Console.WriteLine("Enter the value of (x1)");
                int x1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the value of (x2)");
                int x2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the value of (y1)");
                int y1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the value of (y2)");
                int y2 = Convert.ToInt32(Console.ReadLine());
                if (i == 1)
                {
                    length1 = (int)Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
                }
                if (i == 2)
                {
                    length2 = (int)Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
                }
            }
            return length1.CompareTo(length2);
        }
    }
}
