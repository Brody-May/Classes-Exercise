namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new car();
            myCar.Make = "Honda";
            myCar.Model = "Passport";
            myCar.Year = 2021;

            Console.WriteLine($"Year: {myCar.Year}");
            Console.WriteLine($"Make: {myCar.Make}");
            Console.WriteLine($"Model: {myCar.Model}");
        }
    }
}
