/*
4 2 10 5
3 15 15 11 6

1 5 28 1 4
3 18 1 9 30 4 5

10 20 30 40 50
20 11

*/

Queue<int> cups = new Queue<int>(Console.ReadLine()
    .Split()
    .Select(int.Parse));

Stack<int> bottles = new Stack<int>(Console.ReadLine()
    .Split()
    .Select(int.Parse));

int wastedLiters = 0;

while (cups.Any() && bottles.Any())
{
    int currentBottle = bottles.Pop();
    int currentCup = cups.Dequeue();

    currentCup -= currentBottle;

    while (currentCup > 0 && bottles.Any())
    {
        currentCup -= bottles.Pop();
    }

    if (currentCup < 0)
    {
        wastedLiters += currentCup;
    }
}

if (bottles.Count > 0)
{
    Console.WriteLine($"Bottles: {string.Join(" ",bottles)}");
}
else
{
    Console.WriteLine($"Cups: {string.Join(" ",cups)}");
}

Console.WriteLine($"Wasted litters of water: {wastedLiters * -1}");