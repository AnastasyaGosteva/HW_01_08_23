// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int CalculationSumm(int firstNumber, int secondNumber)
{
    if (firstNumber == secondNumber) return secondNumber;
    else return firstNumber + CalculationSumm(firstNumber + 1, secondNumber);
}

Console.Write("Задайте значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
int summ = CalculationSumm(n, m);
Console.WriteLine(summ);