// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет

Console.Clear();
Console.Write("Введите число: ");

string s_n_1 = Console.ReadLine();
int n_1 = int.Parse(s_n_1);

int TheSecDigit(int num)
{
    while(num>999) num/=10;
    return(num%10);
}
if (n_1 > 99)
{
    Console.Write("Третья цифра: ");
    Console.WriteLine(TheSecDigit(n_1));
}
else
{
    Console.Write("Третьей цифры нет ");
}