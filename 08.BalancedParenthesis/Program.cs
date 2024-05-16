/*
{[()]}

{[(])}

{{[[(())]]}}

 */

Stack<char> stack = new Stack<char>();

string input = Console.ReadLine();

bool isBalanced = true;
foreach (var item in input)
{
    if (item is '(' or '[' or '{')
    {
        stack.Push(item);
        continue;
    }

    bool canPeek = stack.TryPeek(out char currentChar);

    if (canPeek &&
        ((currentChar == '(' && item == ')')
        || (currentChar == '[' && item == ']')
        || (currentChar == '{' && item == '}')))
    {
        stack.Pop();
    }
    else
    {
        isBalanced = false;
        break;
    }
}
if (isBalanced)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}