namespace CaceresConsole
{
    // Luis Caceres
    // Sept. 20
    // My first console app
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Please enter your name here -> ");
            string myName = Console.ReadLine();
            string city = "Sogamoso";
            string country = "Colombia";
            string interests = "I like videogames and cats";
            Console.WriteLine("The name entered was " +  myName);
            Console.WriteLine("I am from " + city + ", " + country);
            Console.WriteLine(interests);
            Console.ReadKey();
        }
    }
}