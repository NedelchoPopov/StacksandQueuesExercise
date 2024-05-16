/*
5 2 32
1 13 45 32 4

4 1 666
666 69 13 420

3 3 90
90 0 90

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

Queue<int> queue = new Queue<int>();

for (int i = 0; i < n; i++)
{
    int num = elements[i];

    queue.Enqueue(num);
}

for (int i = 0; i < s; i++)
{
    queue.Dequeue();
    if (queue.Count == 0)
    {
        break;
    }
}

if (queue.Contains(x))
{
    Console.WriteLine("true");
}
else
{
    if (queue.Count > 0)
    {
        Console.WriteLine(queue.Min());
    }
    else 
    { 
        Console.WriteLine(0); 
    }
}

