double firstValue, secondValue;
string operation;

Console.WriteLine("Введите число 1");
firstValue = double.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2");
secondValue = double.Parse(Console.ReadLine());

Console.WriteLine("Выберите операцию над числами: '+' '-' '*' '/' ");
operation = Console.ReadLine();

if (operation == "+")
{
    Console.WriteLine(firstValue + secondValue);
}
else if (operation == "-")
{
    Console.WriteLine(firstValue - secondValue);
}
else if (operation == "*")
{
    Console.WriteLine(firstValue * secondValue);
}
else if (operation == "/")
{
    if (secondValue == 0)
        Console.WriteLine("Ошибка! На ноль делить нельзя!");
    else
    Console.WriteLine(firstValue / secondValue);
}
else
{
    Console.WriteLine("Ошибка! Неизвестной действие!");
}
Console.ReadLine();
