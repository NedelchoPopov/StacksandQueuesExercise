/*
5 2 13
1 13 45 32 4

4 1 666
420 69 13 666

3 3 90
90 90 90

 */

int[] operations = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] elements = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int n = operations[0];

int s = operations[1];

int x = operations[2];

Stack<int> stack = new Stack<int>();


for (int i = 0; i < n; i++)
{
    int num = elements[i];

    stack.Push(num);
}

for (int i = 0;i < s; i++)
{
    stack.Pop();
    if (stack.Count == 0)
    {
        break;
    }
}

if (stack.Contains(x))
{
    Console.WriteLine("true");
}
else
{
     if (stack.Count > 0)
    {
        Console.WriteLine($"{stack.Min()}");
    }
    else
    {
        Console.WriteLine(0);
    }
}



    
