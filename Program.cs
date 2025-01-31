namespace NameControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma nini");
            Console.WriteLine("Sisesta oma nimi:");
            string nimi = Console.ReadLine();

            if (nimi != "")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Tere " + nimi);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR");
                Console.Beep();
                Console.Beep();
                Console.Beep();
            }
                    
        }
    }
}
