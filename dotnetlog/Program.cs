using System;

class Program
{
    static void Main()
    {
        string value = Environment.GetEnvironmentVariable("MY_TEST_VAR");

        if (string.IsNullOrEmpty(value))
        {
            Console.WriteLine("❌ Environment variable MY_TEST_VAR is not set.");
        }
        else
        {
            Console.WriteLine($"✅ MY_TEST_VAR = {value}");
        }
    }
}
