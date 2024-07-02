/*Функция max */

//  определим с какими типами данных будет работать метод: $> Max(int )

// определим возвращаемый тип данных для этого метода $> int Max(int ) , если мы будем работать с целочисленными числами , то и функция будет возвращать ее.

/* Чем будет заниматься наш метод? Для начала начнем с простого и сравним "3 тройки тройки игроков" узнаем максимальное число в первой тройке числе 1-3; второй 4-6; 
 * и в третьей с 6 до 9. А после чего устроим "битву победителей" где останеться только один верный Max или одинаковые значения на этой позиции. */

// Раз так , то метод будет принимать для сравнения 3 аргумента: $> int Max(int arg1,arg2,arg3)


int Max(int arg1, int arg2, int arg3) // Определения возвращаемого значения , имя Метода(Max); опеределение дата тип для принимаемых аргументов
{
    int resolt = arg1;  // определяем переменную для хранения ответа

    if(arg2 > resolt) resolt = arg2;        //  определяем тело метода , сравниваем
    if(arg3 > resolt) resolt = arg3;       //   сравниваем
    return resolt;                        //    возвращаем результат 
} 

// Наш метод выстроен, теперь его можно применять, каким образом, узанем дальше
// Дальше мы можем применить наш метод для для любых 9-ти чисел.

int a1, a2, a3, a4, a5, a6, a7, a8, a9;   // создание 9-ти переменных

Console.Write("Enter integer: ");
while(!int.TryParse(Console.ReadLine(), out a1)) // ввод данных (integer)
{
    Console.WriteLine("input error ");
    Console.Write("Enter integer :");
}

Console.Write("Enter integer: ");
while (!int.TryParse(Console.ReadLine(), out a2))
{
    Console.WriteLine("input error ");
    Console.Write("Enter integer :");
}

Console.Write("Enter integer: ");
while (!int.TryParse(Console.ReadLine(), out a3))
{
    Console.WriteLine("input error ");
    Console.Write("Enter integer :");
}

Console.Write("Enter integer: ");
while (!int.TryParse(Console.ReadLine(), out a4))
{
    Console.WriteLine("input error ");
    Console.Write("Enter integer :");
}

Console.Write("Enter integer: ");
while (!int.TryParse(Console.ReadLine(), out a5))
{
    Console.WriteLine("input error ");
    Console.Write("Enter integer :");
}

Console.Write("Enter integer: ");
while (!int.TryParse(Console.ReadLine(), out a6))
{
    Console.WriteLine("input error ");
    Console.Write("Enter integer :");
}

Console.Write("Enter integer: ");
while (!int.TryParse(Console.ReadLine(), out a7))
{
    Console.WriteLine("input error ");
    Console.Write("Enter integer :");
}

Console.Write("Enter integer: ");
while (!int.TryParse(Console.ReadLine(), out a8))
{
    Console.WriteLine("input error ");
    Console.Write("Enter integer :");
}

Console.Write("Enter integer: ");
while (!int.TryParse(Console.ReadLine(), out a9))
{
    Console.WriteLine("input error ");
    Console.Write("Enter integer :");
}

Console.WriteLine($"{a1} , {a2}, {a3}, {a4}, {a5}, {a6}, {a7}, {a8}, {a9}");

// Так -как мы будем сравнивать тройками , то для хранения результата нам пондадабятся еще несколько дополнителный переменных: max1; max2; max3 and resolt

//int max1 = Max(a1, a2, a3); // создаем переменные и вкладываем результат сравнения первых 3-х чисел
//int max2 = Max(a4, a5, a6); // создаем переменные и вкладываем результат сравнения вторых 3-х чисел
//int max3 = Max(a7, a8, a9); // создаем переменные и вкладываем результат сравнения третьих 3-х чисел

//int resolt = Max(max1, max2, max3); // создаем переменные и вкладываем результат сравнения победеителй своих троек (из каждой тройки чисел макс) х чисел
//Console.WriteLine(resolt);             // печать результата

// Далее мы можем сократить наш код а вместе с ней и память, так как переммых понадобиться меньше.

int max = Max(        // таким образом обарачиваем функцию в функцию , тем самым экономя и время и производительность
    Max(a1, a2, a3),
    Max(a4, a5, a6),
    Max(a7, a8, a9));
Console.WriteLine(max);