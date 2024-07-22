namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hello, Welcome to the Temperature Conversion App!");
                Console.WriteLine("=================================================");
                Console.WriteLine("\nWhat would you like to convert? Please select an option");
                Console.WriteLine("\n1. Fahrenheit to Celsius");
                Console.WriteLine("2. Celsius to Fahrenheit");
                Console.WriteLine("-------------------------------------------------");


                int option;

                if (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Invalid input. Please enter a valid option.");
                    continue;
                }

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Please enter the degrees in Fahrenheit to be converted to Celsius");
                        double f = 0;

                        if (!double.TryParse(Console.ReadLine(), out f))
                        {
                            Console.WriteLine("Invalid Temperature. Please enter a valid temperature");
                            continue;
                        }
                        

                        Console.WriteLine($"\n");
                        Console.WriteLine($"{f} degrees Fahrenheit is {TempConverter.FtoC(f)} degreees Celsius\n");
                        Console.WriteLine($"\n");
                        Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                        break;
                    case 2:
                        Console.WriteLine("Please enter the degrees in Celsius to be converted to Fahrenheit");
                        double c = 0;

                        if (!double.TryParse(Console.ReadLine(), out c))
                        {
                            Console.WriteLine("Invalid Temperature. Please enter a valid temperature");
                            continue;
                        }
                        Console.WriteLine($"\n");
                        Console.WriteLine($"{c} degrees Celsius is {TempConverter.FtoC(c)} degrees Fahrenheit\n");
                        Console.WriteLine($"\n");
                        Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++");
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter valid temerture");
                        break;
                        
                }
            }
        }
    }
}