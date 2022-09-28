void Task25()
{
    // Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
    Console.Write("Введите число А: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число B: ");
    int b = Convert.ToInt32(Console.ReadLine());
    int res = a;

    for(int i = 2; i <= b; i++)
    {
        res = res * a;
    }
    Console.WriteLine($"{a} в степени {b} равно {res}");
}
void Task27()
{
    // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    Console.Write("Введите число: ");
    int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    int sum = 0;

    while(number > 0){
        sum = sum + (number % 10);
        number /= 10;
    }
    Console.WriteLine($"Сумма цифр равна {sum}");
}
void Task29()
{

}

//Task25();
Task27();
//Task29();