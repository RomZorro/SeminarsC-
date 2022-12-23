// Задача 26
// Напишите программу, которая принимает на вход число и выдает количество цифр в числе
// 456 - 3 
// 78 - 2
// 89126 - 5

int InputNumber();
{
    int number;
    string text;
    while (true)
    {
        System.Console.WriteLine("Введите число");
        text = Console.ReadLine();
        if (int.TryParse(text, out number));
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, поробуйте ввести число заново");
        
    }
    return number
}