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
    // Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
    int[] numbers = new int[8];
    FillArray(numbers);
    Console.Write("Начальный массив:       ");
    ShowArray(numbers);
    Console.WriteLine();
    SortArray(numbers);
    Console.Write("Отсортированный массив: ");
    ShowArray(numbers);
}
void SortArray(int[] arr){
    int temp = 0;
    for(int i = 0; i < arr.Length - 1; i++)
    {
        for(int j = i + 1; j < arr.Length; j++)
        {
            if(Math.Abs(arr[i]) > Math.Abs(arr[j]))
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
}
void FillArray(int[] arr)
{
    Random random = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(-99, 100);
    }
}
void ShowArray(int[] arr)
{
    Console.Write("{");
    for(int i = 0; i < arr.Length; i++)
    {   
        if(i + 1 !=  arr.Length)
        {
            Console.Write(arr[i] + ", ");
        }
        else
        {
            Console.Write(arr[i]);
        }
    }
    Console.Write("}");
}
//Task25();
//Task27();
Task29();