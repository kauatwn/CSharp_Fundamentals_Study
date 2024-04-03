namespace Generics.ConsoleApp.Helpers
{
    internal class CalculationHelper
    {
        // Retorno é um tipo genérico.
        // Há uma restrição em que T deve ser uma classe que implementa IComparable.
        public static T FindMaxValue<T>(List<T> list) where T : class, IComparable<T>
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("The list cannot be empty.");
            }

            T maxValue = list[0];
            foreach (T item in list)
            {
                if (item.CompareTo(maxValue) > 0)
                {
                    maxValue = item;
                }
            }
            return maxValue;
        }
    }
}
