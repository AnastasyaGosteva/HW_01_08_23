double FunctionAkkerman(double numberFirst, double numberSecond)
{
    double Akkerman = 0;
    if (numberFirst == 0)
    {
        Akkerman = numberSecond + 1;
    }
    else if (numberFirst > 0 && numberSecond == 0)
    {
        Akkerman = FunctionAkkerman(numberFirst - 1, 1);
    } 
    else if (numberFirst > 0 && numberSecond > 0)
    {
        Akkerman = FunctionAkkerman(numberFirst - 1, FunctionAkkerman(numberFirst, numberSecond - 1));
    }
    return Akkerman;
}
double GetInput (string text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}
double number1 = GetInput("Введите первое положительное число: ");
double number2 = GetInput("Введите второе положительное число: ");
if (number1 >= 0 && number2 >= 0)
{   
    Console.WriteLine(FunctionAkkerman(number1, number2));
}
else Console.Write("Числа введенные неверно, поробуйте запустить программу снова!!!");