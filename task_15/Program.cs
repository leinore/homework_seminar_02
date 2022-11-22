// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.Write("Введите цифру: ");
int number = Convert.ToInt32(Console.ReadLine());

void dayOfWeek (int number) 
{
    if (number == 6 || number == 7) 
    {
        Console.WriteLine("Этот день недели выходной");
    }
        else if (number < 1 || number > 7) 
        {
            Console.WriteLine("Это не день недели");
        }
    else Console.WriteLine("Этот день не выходной");
}

dayOfWeek(number);