using System;
using System.Collections.Generic;

class Program
{
    // Basic Recursive Method
    static double PredictFutureValue(double initialValue, double growthRate, int years)
    {
        if (years == 0)
            return initialValue;

        return PredictFutureValue(initialValue, growthRate, years - 1) * (1 + growthRate);
    }

    // Optimized Recursive Method with Memoization
    static double PredictFutureValueMemo(double initialValue, double growthRate, int years, Dictionary<int, double> memo)
    {
        if (years == 0)
            return initialValue;

        if (memo.ContainsKey(years))
            return memo[years];

        double result = PredictFutureValueMemo(initialValue, growthRate, years - 1, memo) * (1 + growthRate);
        memo[years] = result;

        return result;
    }

    static void Main(string[] args)
    {
        double initialValue = 10000;   // Initial investment
        double growthRate = 0.10;      // 10% annual growth
        int years = 10;

        Console.WriteLine(" Financial Forecasting (Recursive)");

        // Without memoization
        double futureValue = PredictFutureValue(initialValue, growthRate, years);
        Console.WriteLine($"Future value after {years} years (no memo): ₹{futureValue:F2}");

        // With memoization
        var memo = new Dictionary<int, double>();
        double memoizedValue = PredictFutureValueMemo(initialValue, growthRate, years, memo);
        Console.WriteLine($"Future value after {years} years (memoized): ₹{memoizedValue:F2}");

        // Analysis
        Console.WriteLine("\n Analysis:");
        Console.WriteLine("- Time Complexity (basic recursion): O(n)");
        Console.WriteLine("- Optimized with memoization to reduce repeated calls.");
    }
}
