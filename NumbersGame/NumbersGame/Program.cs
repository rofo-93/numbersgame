namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
            Random random = new Random();
            int number = random.Next(1, 20);
            bool CheckGuess(int guesser, int number)
            {
                return guesser == number;
            }

            for (int n = 0; n < 5; n++)
            {
                Console.WriteLine("Gissa ett tal:");
                int guesser = Convert.ToInt32(Console.ReadLine());

                if (CheckGuess(guesser, number))
                {
                    Console.WriteLine("Wohoo! Du klarade det!");
                    return;
                }

                if (guesser < number)
                {
                    Console.WriteLine("Tyvärr, du gissade för lågt!");
                }
                else
                {
                    Console.WriteLine("Tyvärr, du gissade för högt!");
                }


            }





        }
    }
}
