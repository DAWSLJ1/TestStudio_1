namespace TestStudio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Zac lab 10
            Random random = new Random();
            int[] dice = new int[6];
            for (int i = 0; i < 6000; i++) dice[random.Next(6)]++;
            Console.WriteLine($"results \t1\t2\t3\t4\t5\t6\n6000 \t\t{dice[0]}\t{dice[1]}\t{dice[2]}\t{dice[3]}\t{dice[4]}\t{dice[5]}");
            Console.ReadLine();
        }
    }
}
