namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var newCar = new Car();
            newCar.Make = "Honda";
            newCar.Model = "Pilot";
            newCar.Year = 2017;

            Console.WriteLine($"{newCar.Make} {newCar.Model} {newCar.Year}");
        }
    }
}
