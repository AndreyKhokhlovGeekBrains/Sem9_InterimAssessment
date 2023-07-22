// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

string promptM = "Введите число M: ";
Console.WriteLine(promptM);
int numberM = CheckForNumber(Console.ReadLine(), promptM);

string promptN = "Введите число N: ";
Console.WriteLine(promptN);
int numberN = CheckForNumber(Console.ReadLine(), promptN);

Console.Write(ComputeAckermannFunction(numberM, numberN));

//--//--//

int ComputeAckermannFunction(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    else if(numberM > 0 && numberN == 0) return ComputeAckermannFunction(numberM - 1, 1);
    else return ComputeAckermannFunction(numberM - 1, ComputeAckermannFunction(numberM, numberN - 1));
}

int CheckForNumber(string value, string prompt)
{
    if (int.TryParse(value, out int number) && number >= 0) return number;
    else
    {
        Console.WriteLine("Введено некорректное значение");
        Console.WriteLine(prompt);
        string newValue = Console.ReadLine();
        return CheckForNumber(newValue, prompt);
    }
}