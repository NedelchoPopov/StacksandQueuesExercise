/*
5 4 8 6 3 8 7 7 9
16

1 7 8 2 5 4 7 8 9 6 3 2 5 4 6
20

*/

Stack<int> clothesValues = new Stack<int>(Console.ReadLine()
    .Split()
    .Select(int.Parse));

int rackCapacity = int.Parse(Console.ReadLine());

int currentRackCapacity = 0;

int rackCount = 1;


while (clothesValues.Any())
{
    int currentClothe = clothesValues.Pop();

    if (currentClothe + currentRackCapacity <= rackCapacity)
    {
        currentRackCapacity += currentClothe;
    }
    else
    {
        currentRackCapacity = currentClothe;
        rackCount++;
    }
}
Console.WriteLine(rackCount);

    