/*
3
1 5
10 3
3 4

 */


Queue<(int, int)> petrolPumps = new Queue<(int, int)>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int[] input = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();

    int petrol = input[0];
    int km = input[1];

    petrolPumps.Enqueue((petrol, km));

}

int startIndex = 0;

while (true)
{
    int totalPetrol = 0;

    foreach ((int, int) item in petrolPumps)
    {
        totalPetrol += item.Item1;
        int km = item.Item2;

        totalPetrol -= km;

        if (totalPetrol < 0)
        {
            break;
        }

    }
        if (totalPetrol < 0)
        {
            startIndex++;
            petrolPumps.Enqueue(petrolPumps.Dequeue());
        }
        else
        {
            break;
        }
}
Console.WriteLine(startIndex);



