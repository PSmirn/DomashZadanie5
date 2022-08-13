
void Zadacha41()
{
    Console.Write("Количество цифр, которых хотите ввести: " );
    int Count = int.Parse(Console.ReadLine());
    int[] array = new int[Count];
    int KolMaxZero = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите число: ");
        array[i] =  int.Parse(Console.ReadLine());
        if (array[i] > 0)
        {
          KolMaxZero += 1;  
        }
    }
    Console.WriteLine("Чисел больше нуля: " + KolMaxZero);    
}
void Zadacha43()
{
    Console.Write("Введите значение b1 = ");
    double b1 = int.Parse(Console.ReadLine());
    Console.Write("Введите значение k1 = ");
    double k1 = int.Parse(Console.ReadLine());    
    Console.Write("Введите значение b2 = ");
    double b2 = int.Parse(Console.ReadLine());
    Console.Write("Введите значение k2 = ");
    double k2 = int.Parse(Console.ReadLine());

    if (k1 == k2)
    {
       Console.WriteLine("Прямые паралельны.");
    }
    else
    {
    double x = (b1 - b2)/(k1 - k2);
    double y = (k1 * x) + b1;
    Console.Write("Координаты точки: " + x +", "+ y);
    }
}

Zadacha43();