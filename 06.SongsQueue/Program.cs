/*
All Over Again, Watch Me
Play
Add Watch Me
Add Love Me Harder
Add Promises
Show
Play
Play
Play
Play

 */

Queue<string> songPlayList = new Queue<string>(Console.ReadLine()
    .Split(", "));



while (songPlayList.Count > 0)
{
    string input = Console.ReadLine();
    string[] arguments = input.Split();
    string command = arguments[0];

    switch (command)
    {
        case "Add":
            string songName = string.Join(" ", arguments.Skip(1));
            if (songPlayList.Contains(songName))
            {
                Console.WriteLine($"{songName} is already contained!");
            }
            else
            {
                songPlayList.Enqueue(songName);
            }
            break;
        case "Show":
            Console.WriteLine(string.Join(", ",songPlayList));
            break;
        case "Play":
            songPlayList.Dequeue();
            break;

    }

}
Console.WriteLine("No more songs!");

