using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace code;

public class Processor1
{
    public static long Process(string[] input)
    {
        long result = 0;
        // Console.WriteLine(input.Length);

        for (int i = 0; i < input.Length; i++)
        {
            // var numbers = ProcessAString(input[i]);
            var leftNumber = GetFirstNumber(input[i]);
            var rightNumber = GetLastNumber(input[i]);

            var tempNumber = ReturnTheNumber(leftNumber, rightNumber);

            result = result + tempNumber;
        }
        return result;
    }

    public static string GetFirstNumber(string input)
    {
        string result = "";
        //get the first digit char in the string from left to right
        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsDigit(input[i]))
            {
                result += input[i];
                break;
            }
        }
        // Console.WriteLine(result);
        return result;
    }

    public static string GetLastNumber(string input)
    {
        string result = "";
        //get the last digit char in the string from right to left
        for (int i = input.Length - 1; i >= 0; i--)
        {
            if (char.IsDigit(input[i]))
            {
                result += input[i];
                break;
            }
        }
        return result;
    }


    public static int ReturnTheNumber(string left, string right)
    {
        // get the first number and the last number, make them a string and parse them to int
        string numberWord = $"{left}{right}";
        if (numberWord == "")
        {
            return 0;
        }
        int result = int.Parse(numberWord);
        // Console.WriteLine(result);
        return result;
    }

}
