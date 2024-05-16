namespace C_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Buhgalter Sveta = new Buhgalter("Sveta");
            Manager Sashka = new Manager("Sashka", 20);
            Sashka.Print();
            GeneralManager Vitka = new GeneralManager("Vitka", 45);
            Vitka.Print();
            Console.Write("Светка насчитала налога манагеру: ");
            Console.WriteLine(Sveta.Сalculation(Sashka, 20));

            Class2 a = new Class2();
            a.print2();
            
        }
    }
}
