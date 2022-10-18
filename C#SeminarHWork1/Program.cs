Console.WriteLine("Input Number1");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Number2");
int Number2 = Convert.ToInt32(Console.ReadLine());
if(Number1 == Number2)
    Console.WriteLine($"Number {Number1} is equally Number {Number2}");   
else if(Number1 > Number2)
    Console.WriteLine($"Number {Number1} is upper Number {Number2}");
else
    Console.WriteLine($"Number {Number2} is upper Number {Number1}");