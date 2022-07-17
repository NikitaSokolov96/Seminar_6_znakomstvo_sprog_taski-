// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Enter yours massive");
    var a = Console.ReadLine()
        .Split(new[] {" "},StringSplitOptions.RemoveEmptyEntries)
        .Select(Int32.Parse);
    int positives = 0;
    foreach (var i in a)
{
    if (i > 0)
    {
        positives++;
    }
}
Console.WriteLine("Positives: {0}", positives);