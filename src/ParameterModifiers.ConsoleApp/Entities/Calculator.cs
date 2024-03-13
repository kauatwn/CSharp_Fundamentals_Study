namespace ParameterModifiers.ConsoleApp.Entities
{
    internal static class Calculator
    {
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        // Não se utiliza return com ref, pois a variável será referenciada
        public static void Triple(ref int number)
        {
            number *= 3;
        }

        // Não se utiliza return com out, pois o resultado e o resto da divisão será referenciado
        public static void Divide(double dividend, double divisor, out double result, out double remainder)
        {
            result = dividend / divisor;
            remainder = dividend % divisor;
        }
    }
}
