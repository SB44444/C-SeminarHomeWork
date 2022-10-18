/* Семинар 1  Задача № 2
 Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее, исключена ошибка,
 если введенные числа равны */

/* Console.WriteLine("Input Number1");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Number2");
int Number2 = Convert.ToInt32(Console.ReadLine());
if(Number1 == Number2)
    Console.WriteLine($"Number {Number1} is equally Number {Number2}");   
else if(Number1 > Number2)
    Console.WriteLine($"Number {Number1} is upper Number {Number2}");
else
    Console.WriteLine($"Number {Number2} is upper Number {Number1}"); */

/* Семинар 1  Задача № 4  программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел */
Console.WriteLine("Input Number1");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Number2");
int Number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Number3");
int Number3 = Convert.ToInt32(Console.ReadLine());
int NumberMax = Number1;
if (NumberMax < Number2)
    NumberMax = Number2;
if (NumberMax < Number3)
    NumberMax = Number3;
Console.WriteLine($"The maximunm dight is Number {NumberMax}");
