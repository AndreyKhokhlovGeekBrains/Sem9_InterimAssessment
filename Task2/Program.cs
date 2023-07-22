// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке 
// от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

string promptM = "Введите число M: ";
Console.WriteLine(promptM);
int numberM = CheckForNumber(Console.ReadLine(), promptM);

string promptN = "Введите число N: ";
Console.WriteLine(promptN);
int numberN = CheckForNumber(Console.ReadLine(), promptN);

Console.Write(ReturnSumOfNumbers(numberM, numberN));

//--//--//

int ReturnSumOfNumbers(int numberM, int numberN)
{
    int sum = 0;
    int min = Math.Min(numberN, numberM);
    int max = Math.Max(numberN, numberM);

    if (min == max) return sum += max;
    else
    {
        return sum += min + ReturnSumOfNumbers(min + 1, max);
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