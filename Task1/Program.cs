// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 465->5

Console.Clear();
Console.Write("Введите трёхзначное число: ");

string s_n_1 = Console.ReadLine();
int n_1 = int.Parse(s_n_1);

int TheSecDigit(int num)
{
    return (num / 10 % 10);
}

Console.Write("Вторая цифра: ");
Console.WriteLine(TheSecDigit(n_1));
