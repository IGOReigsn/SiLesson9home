/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

// -------------------РАНЕЕ ИСПОЛЬЗОВАВШИЕСЯ МЕТОДЫ----------------------------------------------------------------------------
int InputNumber(string qwerStr)//проверяет "численность"."Не выпускает" без ввода ЧИСЛА
{
    int num;
    string? text;
    while (true)
    {
        Console.WriteLine(qwerStr);
        text = Console.ReadLine();
        if (int.TryParse(text, out num)) break;
        Console.WriteLine("Введено некорректное значение.Попробуйте еще раз");
    }
    return num;
}
//------------------------------------------------------------------------------------------------------
int InputNumberWithFilter(string qwerStr, bool zeroEnable, bool negativEnable)//Пропускает положительные. 0 и отрицательные пропускает в соответствии со булевыми значениями zeroEnable,negativEnable
{
    int num;
    while (true)
    {
        num = InputNumber(qwerStr);//проверяет "численность"."Не выпускает" без ввода ЧИСЛА
        if (num > 0 || num == 0 && zeroEnable || num < 0 && negativEnable) break;
        Console.WriteLine("Введено не разрешенное значение.Попробуйте еще раз");
    }
    return num;
}
//-------------------МЕТОД С РЕКУРСИЕЙ----------------------------------------------------------------------------------
int RecSum(int m, int n)
{
    if (n > m)
    {
        return n + RecSum(m, n - 1);
    };
    return m;
}
//------------------------------------------------------------------------------------------------------
// -------------------ОСНОВНАЯ ПРОГРАММА----------------------------------------------------------------------------
int numM = InputNumberWithFilter("Введите начальный элемент (число) :", false, false);
int numN = InputNumberWithFilter("Введите конечный элемент (число) :", false, false);
if (numM > numN)//если нарушен порядок по величинам
{
    int temp = numM; numM = numN; numN = temp;//Меняем элементы местами
}
System.Console.WriteLine($" Результат= {RecSum(numM, numN)}");