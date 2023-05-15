namespace FirstProject;
class Program
{
    static void Main(string[] args)
    {

        //Type Casting
        double a = 3.14;
        // Int -> decimals are truncated
        int b = Convert.ToInt32(a);

        int c = 123;
        double d = Convert.ToDouble(c);

        int e = 321;
        String f = Convert.ToString(e);


        Console.WriteLine(a);
        Console.WriteLine(b);

        Console.WriteLine(d);

        Console.WriteLine(f.GetType());
        Console.WriteLine("Hello, World!");

        Console.WriteLine("What is your age?");

        //int age = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine(age);

        //Console.WriteLine(10 / 3);

        double ab = Math.Pow(a, 2);

        double abc = Math.Sqrt(a);

        Console.WriteLine(ab);

        // Random Numbers
        Random random = new Random();

        // Generate random integer between 1 - 7
        int num = random.Next(1, 7) + 100;

        Console.WriteLine(num);

        String[] cars = { "BMW", "Mustang", "Corvette" };

        foreach (String car in cars)
        {
            Console.WriteLine(car);
        }

        // Exceptions = errors that occur during execution

        // try = try some code that is considered "dangerous"
        // catch = catchees and handles exceptions when they occur
        // finally = always executes regardless if the exception is caught or not

        //try
        //{
        //    repeatNTimes(10);
        //    repeatNTimes(5, "Hey");
        //    double cost = CheckOut(1.2, 2.4);
        //    Console.WriteLine(cost);
        //    // FormatException caught when user types in a non-number input
        //    int x = Convert.ToInt32(Console.ReadLine());
        //}

        //catch (FormatException)
        //{
        //    Console.WriteLine("Type numbers");
        //}

        //Ternary/Conditional Operator

        double costTotal = CheckOut(1.2, 2.4);
        Console.WriteLine(costTotal > 5.0 ? true : false);

        // String interpolation -> inserting variables into strings, using $ and {}

        Console.WriteLine($"The total cost of your cart is {costTotal}");

        // Multi-dimensional array
        // Take note of the comma in the String[,] declration for type
        String[,] parkingLot = { { "Car1", "Car2" }, { "Car3", "Car4" } };


    }
    static void repeatNTimes(int n)
    {
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine("For What");
        }
    }

    // Overloaded method
    // Method name + parameters -> method signature
    static void repeatNTimes(int n, String whatToPrint)
    {
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine(whatToPrint);
        }
    }

    // Taking potentially more than 1 argument
    static double CheckOut(params double[] prices)
    {
        double total = 0;

        foreach(double price in prices)
        {
            total += price;
        }

        return total;
    }
}

