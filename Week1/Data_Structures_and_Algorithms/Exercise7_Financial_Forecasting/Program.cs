using System;

class Program
{

    static double CalculateFutureValue(double presentValue, double rate, int years)
    {
        if (years == 0)
            return presentValue;

        return (1 + rate) * CalculateFutureValue(presentValue, rate, years - 1);
    }

    static double CalculateFutureValueMemo(double presentValue, double rate, int years, double[] memo)
    {
        if (years == 0)
            return presentValue;

        if (memo[years] != 0)
            return memo[years];

        memo[years] = (1 + rate) * CalculateFutureValueMemo(presentValue, rate, years - 1, memo);
        return memo[years];
    }

    static void Main()
    {
        Console.WriteLine("=== Financial Forecasting Tool ===");

        Console.Write("Enter present value (e.g., 1000): ");
        double presentValue = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter annual growth rate in % (e.g., 5): ");
        double ratePercent = Convert.ToDouble(Console.ReadLine());
        double rate = ratePercent / 100.0;

        
        Console.Write("Enter number of years to forecast (e.g., 5): ");
        int years = Convert.ToInt32(Console.ReadLine());

       
        double futureValue = CalculateFutureValue(presentValue, rate, years);
        Console.WriteLine($"\n[Recursive] Future value after {years} years: {futureValue:F2}");

       
        double[] memo = new double[years + 1];
        double futureValueMemo = CalculateFutureValueMemo(presentValue, rate, years, memo);
        Console.WriteLine($"[Memoized] Future value after {years} years: {futureValueMemo:F2}");
    }
}
