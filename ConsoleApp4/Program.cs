
Console.WriteLine("Enter X:");
var X = Console.ReadLine();
var enteredX = int.TryParse(X, out int NewX);

Console.WriteLine("Enter Y:");
var Y = Console.ReadLine();
var enteredY = int.TryParse(Y, out int NewY);

if (enteredX && enteredY)
{
    int sum = 0;
    
    if (NewX == NewY)
    {
        sum = NewX;
        Console.WriteLine(sum);
    }
    else if (NewX > NewY)
    {
        for (int i = NewY; i <= NewX; i++)
        {
            sum = sum + i;
        }
        Console.WriteLine(sum);
    }
    else
    {
        for (int i = NewX; i <= NewY; i++)
        {
            sum = sum + i;
        }
        Console.WriteLine("HERE YOUR RESULT:" + sum);
    }
}
else
{
    Console.WriteLine("NOT SUCCESS");
}