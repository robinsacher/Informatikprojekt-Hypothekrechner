namespace Hypothekenrechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
                  
            Console.WriteLine("Hypothekenrechner");
            Console.WriteLine("");
            
            Console.Write("Bitte geben sie den Betrag der Hypothek ein:");
            double Hypothek = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geben sie den Zinssatz ein:");
            double zinssatz = Convert.ToDouble(Console.ReadLine());




        }
    }
}