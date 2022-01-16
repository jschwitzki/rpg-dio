using rpg.src.Entities;

namespace rpg
{
    public class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 12, "Knight");
            Wizard jennica = new Wizard("Jennica", 99, "White Wizard");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(jennica.Attack(1));
        }
    }
}