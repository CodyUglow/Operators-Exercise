namespace OperatorExercise
{
    public class Program
    {
        public static double AreaofCircle(double radius)
        {
            return Math.PI * radius * radius;
        }
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int sum = a + b;
            int difference = a - b;
            int product = a * b;

            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} with a remainder of {remainder}.");

            Console.WriteLine("Please input the radius of a circle:");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double radius))
            {
                double area = AreaofCircle(radius);
                Console.WriteLine($"The area of a circle with radius {radius} is {area}.");
            }
            else
            {
                Console.WriteLine("Invalid input for radius. Please enter a numeric value.");
            }
        }
    }
}
