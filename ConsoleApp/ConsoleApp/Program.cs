using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть перше число: ");
        string userInput1 = Console.ReadLine();
        double number1 = Convert.ToDouble(userInput1);

        Console.Write("Введіть друге число: ");
        string userInput2 = Console.ReadLine();
        double number2 = Convert.ToDouble(userInput2);

        double sum = number1 + number2;

        Console.WriteLine("Сума цих двох чисел: " + sum);
        Console.ReadLine();
    }
}
