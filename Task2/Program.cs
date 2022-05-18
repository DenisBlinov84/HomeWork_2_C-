// Напишите программу, 
// которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.
// 456->46

void DelSecNum()
{
    int num = new Random().Next(100,1000);
    Console.WriteLine($"Random number: {num}");
    Console.WriteLine($"Result: {num/100}{num%10}");
}

DelSecNum();

