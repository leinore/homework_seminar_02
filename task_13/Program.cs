// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введиту число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberT = Convert.ToString(number);
if (numberT.Length > 2){
  Console.WriteLine("Третья цифра это " + numberT[2]);
}
else {
  Console.WriteLine("Третьей цифры нет");
}