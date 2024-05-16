/*
10
5
Mercedes
green
Mercedes
BMW
Skoda
green
END

9
3
Mercedes
Hummer
green
Hummer
Mercedes
green
END

*/

int greenLight = int.Parse(Console.ReadLine());
int freeWindow = int.Parse(Console.ReadLine());

Queue<string> cars = new Queue<string>();

int carsPasses = 0;
bool isHitted = false;

string command;
while ((command = Console.ReadLine()) != "END")
{
    if (command != "green")
    {
        cars.Enqueue(command);
        continue;
    }

    int currentGreenLight = greenLight;

    while (cars.Count > 0 && currentGreenLight > 0)
    {
        string currentCar = cars.Dequeue();

        if (currentGreenLight - currentCar.Length >= 0)
        {
            currentGreenLight -= currentCar.Length;
            carsPasses++;
            continue;
        }

        if ((currentGreenLight + freeWindow) - currentCar.Length >= 0)
        {
            carsPasses++;
            break;
        }

        char hittedChar = currentCar[currentGreenLight + freeWindow];

        Console.WriteLine("A crash happened!");
        Console.WriteLine($"{currentCar} was hit at {hittedChar}.");
        isHitted = true;
        break;

    }
    if (isHitted)
    {
        break;
    }
}
    if (!isHitted)
    {
      Console.WriteLine("Everyone is safe.");
      Console.WriteLine($"{carsPasses} total cars passed the crossroads.");

    }