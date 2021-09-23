using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter input:");
        var userValue = Convert.ToInt32(Console.ReadLine());

        var operatorObject = new Methods();
        var result = operatorObject.Add(userValue, 4);
        var result2 = operatorObject.Subtract(userValue, 2);
        var result3 = operatorObject.Divide(userValue, 1);
        Console.WriteLine(result);
        Console.WriteLine(result2);
        Console.WriteLine(result3);
        Console.ReadLine();
    }
}

