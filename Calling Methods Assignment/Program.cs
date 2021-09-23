using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter input:");
        var userValue = Convert.ToInt32(Console.ReadLine());

        var operatorObject = new Methods();
        var result = operatorObject.Add(userValue, 4);
        result = operatorObject.Subtract(result, 3);
        result = operatorObject.Divide(result, 1);

        Console.WriteLine(result);
        Console.ReadLine();
    }
}

