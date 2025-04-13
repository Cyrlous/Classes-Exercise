namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var rogue = new Car()
            {
                Make = "Nissan",
                Model = "Rogue",
                Year = 2019
            };
            
            Console.WriteLine($"This car is a {rogue.Year} {rogue.Make} {rogue.Model}.");
        }
    }
}
