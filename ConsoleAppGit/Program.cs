namespace ConsoleAppGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zioperabro");
            Dado d = new Dado();
            int valore = d.Lancia();
            Console.WriteLine(valore);
        }
   }
}
