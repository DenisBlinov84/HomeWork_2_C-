// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите число: ");

string s_n_1 = Console.ReadLine();
int n_1 = int.Parse(s_n_1);

void Weekend(int num)
{
    string text = "нет";
    if (num == 7 || num == 6)
    {
        text = "да";
    }
    Console.WriteLine($"{num} -> {text}");
    
}
Weekend(n_1);

