/*
50
2
11 10 5 11 10 20
15 13 16
1500

20
6
14 13 12 11 10 5
13 3 11 10
800

33
1
12 11 10
10 20 30
100

 */

int priceOfBullet = int.Parse(Console.ReadLine());
int sizeOfGunBarrel  = int.Parse(Console.ReadLine());
int[] inputBullets = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int[] inputLock = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int valueOfIntelligence = int.Parse(Console.ReadLine());

Queue<int> locks = new Queue<int>(inputLock);
Stack<int> bullets = new Stack<int>(inputBullets);

int shootCount = 0;
int totalShoots = 0;

while (locks.Any() && bullets.Any())
{
    int bullet = bullets.Pop();
    int currentLock = locks.Peek();
    shootCount++;
    totalShoots++;

    if (bullet <= currentLock)
    {
        locks.Dequeue();
        Console.WriteLine("Bang!");
    }
    else
    {
        Console.WriteLine("Ping!");
    }

    if (shootCount == sizeOfGunBarrel && bullets.Any())
    {
        Console.WriteLine("Reloading!");
        shootCount = 0;
    }

}
    if (locks.Count > 0)
    {

        Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
    }
    else
    {
        int moneyEarned = valueOfIntelligence - (priceOfBullet * totalShoots);
        Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
    }
