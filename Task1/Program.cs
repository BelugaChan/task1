namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeometryProgr();
        }


        public static void NokGame()
        {
            Random random = new Random();
            Console.WriteLine("Welcome to the Brain Games!");
            string name = string.Empty;
            Console.Write("May I have your name? ");
            name = Console.ReadLine();
            Console.Write($"Hello, {name}!");
            Console.WriteLine("Find the smallest common multiple of given numbers.");
            for (int i = 0; i < 3; i++)
            {
                int val1 = random.Next(1, 101);
                int val2 = random.Next(1, 101);
                int val3 = random.Next(1, 101);
                Console.WriteLine($"Question: {val1} {val2} {val3}");
                int answer;
                Console.Write("Your answer: ");
                int realAnswer = NOK3(val1, val2, val3);
                answer = int.Parse(Console.ReadLine());
                if (answer == realAnswer)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine($"'{answer}' is wrong answer ;(. Correct answer was '{realAnswer}'");
                    Console.WriteLine("Let's try again, Sam!");
                }
            }
            Console.WriteLine("Congratulations, Sam!");
        }

        public static void GeometryProgr()
        {
            


            Console.WriteLine("Welcome to the Brain Games!");
            string name = string.Empty;
            Console.Write("May I have your name? ");
            name = Console.ReadLine();
            Console.Write($"Hello, {name}!");
            Console.WriteLine("Find the smallest common multiple of given numbers.");
            for (int i = 0; i < 3; i++)
            {
                Random random = new Random();
                int startValue = random.Next(2, 9);
                double[] geometry = new double[10];
                geometry[0] = startValue;
                for (int j = 1; j < 10; j++)
                {
                    geometry[j] = Math.Pow((double)startValue, (double)j+1);
                }

                int firstHiddenIndex = random.Next(1, 11);
                Console.Write("Question: ");
                for (int j = 0; j < 10; j++)
                {
                    if (j == firstHiddenIndex) 
                    {
                        Console.Write(".. ");
                    } 
                    else { 
                        Console.Write($"{geometry[j]} ");
                    };

                }
                int answer;
                Console.Write("Your answer: ");
                answer = int.Parse(Console.ReadLine());
                if (answer == geometry[firstHiddenIndex])
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine($"'{answer}' is wrong answer ;(. Correct answer was '{geometry[firstHiddenIndex]}'");
                    Console.WriteLine("Let's try again, Sam!");
                }
            }
            Console.WriteLine("Congratulations, Sam!");
        }

        public static int NOD(int a, int b)
        {
            while(b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static int NOK(int a, int b)
        {
            return (a / NOD(a, b)) * b;
        }

        public static int NOK3(int a, int b, int c)
        {
            return NOK(NOK(a, b), c);
        }
    }
}
