/*
9
1 97
2
1 20
2
1 26
1 20
3
1 91
4

9
1 47
1 66
1 32
4
3
1 25
1 16
1 8
4

 */

int n = int.Parse(Console.ReadLine());

Stack<int> stack = new Stack<int>();

for (int i = 0; i < n; i++)
{
   
    string command = Console.ReadLine();

    string[] arguments = command.Split();
    string arg = arguments[0];
    
    switch (arg)
    {
        case "1":
            stack.Push(int.Parse(arguments[1]));
            break;
        case "2":
            stack.Pop();
            break; 
        case "3":
            if (stack.Count != 0)
            {
                Console.WriteLine(stack.Max());
            }
            break;
        case "4":
            if (stack.Count != 0) 
            { 
                Console.WriteLine(stack.Min());
            }
            break;
    }
}
Console.WriteLine(String.Join(", ", stack));