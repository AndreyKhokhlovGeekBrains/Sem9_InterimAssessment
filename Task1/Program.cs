// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string prompt = "Введите натуральное число: ";
Console.WriteLine(prompt);
int numberN = CheckForNumber(Console.ReadLine(), prompt);
Console.Write(ReturnNaturalNumbers(numberN));

//--//--//

string ReturnNaturalNumbers(int number)
{
    if (number == 1)
    {
        return number.ToString();
    }
    else
    {
        return number + ", " + $"{ReturnNaturalNumbers(number - 1)}";
    }
}

int CheckForNumber(string value, string prompt)
{
    if (int.TryParse(value, out int number) && number > 0) return number;
    else
    {
        Console.WriteLine("Введено некорректное значение");
        Console.WriteLine(prompt);
        string newValue = Console.ReadLine();
        return CheckForNumber(newValue, prompt);
    }
}