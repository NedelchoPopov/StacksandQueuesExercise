/*
8
1 abc
3 3
2 3
1 xy
3 2
4
4
3 1

9
1 HelloThere
3 7
2 2
3 5
4
3 7
4
1 TestPassed
3 5

 */

Stack<string> stack = new Stack<string>();

uint n = uint.Parse(Console.ReadLine());

string text = string.Empty;

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    string command = input[0];

    switch (command)
    {
        case "1":
            stack.Push(text);
            text += input[1];
            break;
        case "2":
            stack.Push(text);
            int valueToErase = int.Parse(input[1]);
            text = text.Substring(0, text.Length - valueToErase);
            break; 
        case "3":
            int indexToPrint = int.Parse(input[1]);
            Console.WriteLine(text[indexToPrint - 1]);
            break;
        case "4":
            text = stack.Pop();
            break;

    }
}


