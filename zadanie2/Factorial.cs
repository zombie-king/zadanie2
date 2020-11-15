namespace zadanie2
{
    public static class Factorial
    {
        public static ulong CalculateIterative(ulong n)
        {
            ulong result = 1;
            for (ulong i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public static ulong CalculateRecursive(ulong n)
        {
            return n == 0 ? 1 : n * CalculateRecursive(n - 1);
        }

        public static string FormatResult(ulong n, ulong result)
        {
            return $"{n}! = {result}";
        }
    }
}