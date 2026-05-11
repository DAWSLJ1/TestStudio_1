namespace TestStudio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, my name is Josh."); // Added my name to the code - JS


            // Abby's section
            char start, stop;
            string temp;

            Console.Write("What is your starting character? ");
            temp = Console.ReadLine();
            start = Convert.ToChar(temp);

            Console.Write("What is your ending character? ");
            temp = Console.ReadLine();
            stop = Convert.ToChar(temp);

            for (char i = start; (int)i < ((int)stop + 1); i++)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();
        }
    }
}
