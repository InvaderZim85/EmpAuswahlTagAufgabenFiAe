using System.Runtime.InteropServices;

namespace ExampleCode;

internal static class Program
{
    private static void Main()
    {
        Console.WriteLine("Average temperature");
        CalculateAverageTemperature();

        Console.WriteLine("Fibonacci");
        Fibonacci();

        Console.WriteLine("Caeser Cipher");
        CaeserCipher();
    }

    /// <summary>
    /// Calculates the average temperature.
    /// </summary>
    private static void CalculateAverageTemperature()
    {
        List<int> temperatures = new List<int>
        {
            46, 52, 56, 54, 49, 47, 45, 49, 53, 58
        };

        // Calculation with a simple for loop
        // Note: "temperature.Count" returns the amount of elements which are stored in the list.
        double totalFor = 0;
        for (int i = 0; i < temperatures.Count; i++)
        {
            // Add the current temperature to the "total"
            totalFor += temperatures[i];
        }

        // Calculate the result
        double resultForLoop = totalFor / temperatures.Count;

        // Calculation with a simple foreach
        double totalForeach = 0;
        foreach (int temperature in temperatures)
        {
            totalForeach += temperature;
        }

        // Calculate the result
        double resultForeach = totalForeach / temperatures.Count;

        // Calculate with a LinQ expression / command
        // For more information see: https://learn.microsoft.com/de-de/dotnet/csharp/linq/get-started/introduction-to-linq-queries
        double resultLinQ = temperatures.Average();

        // Print the result
        Console.WriteLine($"Result for....: {resultForLoop}");
        Console.WriteLine($"Result foreach: {resultForeach}");
        Console.WriteLine($"Result LinQ...: {resultLinQ}");
        Console.WriteLine();
    }

    /// <summary>
    /// Calculates / generates the fibonacci sequence.
    /// </summary>
    private static void Fibonacci()
    {
        List<int> numbers = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            // Since we always have to calculate the product of the two previous numbers,
            // this is not possible if there is no number or only one number. We therefore
            // enter the first two numbers directly.
            if (i == 0 || i == 1)
            {
                numbers.Add(i);
                continue; // Move directly to the next number
            }

            int firstNumber = numbers[i - 2];
            var secondNumber = numbers[i - 1];
            numbers.Add(firstNumber + secondNumber);
        }

        // Print the numbers
        Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");
        Console.WriteLine();
    }

    /// <summary>
    /// Caeser cipher.
    /// </summary>
    private static void CaeserCipher()
    {
        const string text =
            """
            hmi geiwev-glmjjvi mwx imri qsrseptlefixmwgli wyfwxmxyxmsr, hew limax, nihiv fyglwxefi hiw xibxiw amvh hyvgl kirey imrir erhivir fyglwxefir hiw eptlefixw ivwixdx. 
            hmiwiv eywxeywgl kiwglmilx nihsgl rmglx dyjeippmk, wsrhivr fewmivx eyj dcopmwgliv vsxexmsr hiw eptlefixw yq dimglir, asfim hiv zivairhixi wglpyiwwip mwx.
            """;

        Dictionary<char, int> result = CountCharacters(text);
        char maxChar = GetMaxChart(result);

        Console.WriteLine($"Character with the most occurence: {maxChar}");
    }

    /// <summary>
    /// Calculates the occurence for each character in the given text.
    /// </summary>
    /// <param name="text">The text which should be analyzed.</param>
    /// <returns>The result (character + occurence).</returns>
    private static Dictionary<char, int> CountCharacters(string text)
    {
        Dictionary<char, int> result = new Dictionary<char, int>();

        foreach (var character in text)
        {
            // We have to check if the character is already stored in our result.
            if (result.ContainsKey(character))
            {
                // Increment the count by one
                result[character]++;
            }
            else
            {
                // We start directly with 1
                result.Add(character, 1); 
            }
        }

        return result;
    }

    /// <summary>
    /// Gets the characters which is used the most.
    /// </summary>
    /// <param name="dictionary">The dictionary with the different characters.</param>
    /// <returns>The char which is used the most.</returns>
    private static char GetMaxChart(Dictionary<char, int> dictionary)
    {
        int maxCount = 0;
        char character = char.MinValue;

        foreach (var key in dictionary)
        {
            // Check if the current occurence (key.Value) is higher
            // than the previous, if so, store the current character
            // in the variable.
            if (key.Value > maxCount)
            {
                maxCount = key.Value;
                character = key.Key;
            }
        }

        return character;

        // Other variant with LinQ
        //return dictionary.MaxBy(m => m.Value).Key;
    }
}