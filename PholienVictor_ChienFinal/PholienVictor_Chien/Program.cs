using PholienVictor_Chien;

namespace UAA14_Chien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chien[] chiens = new Chien[10];
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Géneration des chiens");
            for (uint i = 0; i < 10; i++)
            {
                Chien chien = new Chien("rex " + i, "TRex", 2 + i, false, false, "male", false, false);
                chiens[i] = chien;
                Console.WriteLine(chiens[i].AffichageChien());
            }


            for (uint i = 0; i < 10; i++)
            {
                Console.WriteLine(chiens[i].AffichageChien());
            }

        }
    }
}
