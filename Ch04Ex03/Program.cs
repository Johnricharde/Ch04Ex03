namespace Ch04Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string myName = "benjamin";
            const string niceName = "andrea";
            const string sillyName = "ploppy";
            string name;

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            switch(name.ToLower())
            {
                case myName:
                    Console.WriteLine("You have the sam name as me!");
                    break;
                case niceName:
                    Console.WriteLine("You have a nice name!");
                    break;
                case sillyName:
                    Console.WriteLine("You have a silly name!");
                    break;
                default:
                    Console.WriteLine("You have a name!");
                    break;
            }

            Console.WriteLine($"Hello {name}!");
            Console.ReadKey();
        }
    }
}