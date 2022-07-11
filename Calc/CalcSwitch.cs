//с оператором switch
while (true)
{
    Console.Clear();
    double firstValue, secondValue;
    string operation;

    try
    {
        Console.WriteLine("Введите число 1");
        firstValue = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите число 2");
        secondValue = double.Parse(Console.ReadLine());
    }
        catch (Exception)
    {
        Console.WriteLine("Не удалось преобразовать строку в число. Для новой попытки нажмите Enter");
        Console.ReadLine();
        continue;
    }
    Console.WriteLine("Выберите операцию над числами: '+' '-' '*' '/' ");
    operation = Console.ReadLine();

    switch (operation)
    {
        case "+":
            Console.WriteLine(firstValue + secondValue);
            break;
        case "-":
            Console.WriteLine(firstValue - secondValue);
            break;
        case "*":
            Console.WriteLine(firstValue * secondValue);
            break;
        case "/":
            if (secondValue == 0)
            {
                Console.WriteLine("Ошибка! На ноль делить нельзя! Для новой попытки нажмите Enter");
            }
            else
            {
                Console.WriteLine(firstValue / secondValue);
            }
            break;

        default:
            Console.WriteLine("Ошибка! Неизвестное действие! Для новой попытки нажмите Enter");
            break;
    }
    Console.ReadLine();
}