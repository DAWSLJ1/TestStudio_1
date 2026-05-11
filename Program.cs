namespace TestStudio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /* Luke Dawson */

            string temp, guess, cont;
            Random rand = new Random();
            int number, num, contin, tries, wonder;
            number = rand.Next(0, 101);
            contin = 0;


            while (contin != 2)
            {
                tries = 0;
                Console.WriteLine("I'm thinking of a number between 0 and 100");
                Console.WriteLine("Guess what that number is");
                Console.WriteLine($"{number}");
                guess = Console.ReadLine();
                num = Convert.ToInt32(guess);


                while (num != number)
                {
                    if (num < number)
                    {
                        Console.WriteLine($"You chose {num}, The number is higher than that");
                        guess = Console.ReadLine();
                        num = Convert.ToInt32(guess);
                        tries++;
                    }
                    if (num > number)
                    {
                        Console.WriteLine($"You chose {num}, The number is lower than that");
                        guess = Console.ReadLine();
                        num = Convert.ToInt32(guess);
                        tries++;
                    }
                }
                Console.WriteLine("You got it right!!!");
                tries++;
                Console.WriteLine("How many guesses did it take you to do it?");
                temp = Console.ReadLine();
                wonder = Convert.ToInt32(temp);

                if (wonder == tries)
                {
                    Console.WriteLine($"That's correct, you did get it within {tries} tries");
                }
                else
                {
                    Console.WriteLine($"You actually got it in {tries} tries instead");
                }
                Console.WriteLine();
                Console.WriteLine("Do you wish to play again?");
                Console.WriteLine("(1 for Yes, 2 for No)");
                cont = Console.ReadLine();
                contin = Convert.ToInt32(cont);
                number = rand.Next(0, 101);
                Console.WriteLine();




            }
            Console.WriteLine("Thanks for playing :)");
            Thread.Sleep(1200);

            Console.WriteLine("Hello, my name is Josh."); // Added my name to the code - JS


            //Zac lab 10
            Random random = new Random();
            int[] dice = new int[6];
            for (int i = 0; i < 6000; i++) dice[random.Next(6)]++;
            Console.WriteLine($"results \t1\t2\t3\t4\t5\t6\n6000 \t\t{dice[0]}\t{dice[1]}\t{dice[2]}\t{dice[3]}\t{dice[4]}\t{dice[5]}");


            // Abby's section
            char start, stop;
            string temp1;

            Console.Write("What is your starting character? ");
            temp1 = Console.ReadLine();
            start = Convert.ToChar(temp1);

            Console.Write("What is your ending character? ");
            temp1 = Console.ReadLine();
            stop = Convert.ToChar(temp1);

            for (char i = start; (int)i < ((int)stop + 1); i++)
            {
                Console.Write(i + " ");
            }


            Console.ReadLine();

        }
    }
}
