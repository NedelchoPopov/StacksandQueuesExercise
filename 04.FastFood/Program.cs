/*
348
20 54 30 16 7 9

499
57 45 62 70 33 90 88 76

*/

int foodQuantity = int.Parse(Console.ReadLine());

int foodQuantityLeft = foodQuantity;

Queue<int> queue = new Queue<int>(Console.ReadLine()
    .Split()
    .Select(int.Parse));

Console.WriteLine(queue.Max());

while (queue.Count > 0 && foodQuantityLeft > 0)
{
    if (foodQuantityLeft >= queue.First())
    {
        foodQuantityLeft -= queue.Dequeue();
    }
    else
    {
        break;
    }
   
}

if (queue.Count == 0)
{
    Console.WriteLine("Orders complete");
}
else
{
    Console.WriteLine($"Orders left: {String.Join(" ",queue)}");
}