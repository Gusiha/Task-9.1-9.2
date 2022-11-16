using Task_9._1_9._2;

Class_A a = new(); Class_A b = new();
Class_B d = new(); Class_B c = new();

CustomArray<Class_A> newArr = new(2);
newArr[0] = a; newArr[1] = b;

CustomArray<Class_B> scndArr = new(2);
scndArr[0] = d; scndArr[1] = c;


Console.WriteLine("Class A : ");
for (int i = 0; i < 2; i++)
{
    Console.Write($"[{newArr[i].op1} {newArr[i].op2}] ");
}

newArr.Sort();

Console.WriteLine();
Console.WriteLine("New Class A : ");
for (int i = 0; i < 2; i++)
{
    Console.Write($"[{newArr[i].op1} {newArr[i].op2}] ");
}

scndArr.Sort();