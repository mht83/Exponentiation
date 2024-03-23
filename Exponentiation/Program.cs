namespace Exponentiation
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter base: ");
            int baseValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter exponent: ");
            int exponent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Result: {IntegerPower(baseValue, exponent)}");
        }

        static int IntegerPower(int baseValue, int exponent)
        {
            int result = 1;

            for (int i = 0; i < exponent; i++)
                result *= baseValue;

            return result;
        }
    }
}
