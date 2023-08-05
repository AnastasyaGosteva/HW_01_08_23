string СonclusionNumber(int number)
{
    if (number == 1) return number.ToString();
    return number + ", " + СonclusionNumber(number - 1);
}
Console.Write("Задайте значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(СonclusionNumber(n));