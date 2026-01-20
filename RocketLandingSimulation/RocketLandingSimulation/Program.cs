// See https://aka.ms/new-console-template for more information
string RocketImg = "        |\r\n       / \\\r\n      / _ \\\r\n     |.o '.|\r\n     |'._.'|\r\n     |     |\r\n   ,'|  |  |`.\r\n  /  |  |  |  \\\r\n  |,-'--|--'-.| l42";
for (int i = 0; i <= 15; i++)
{
    Console.Clear();
    for (int j = 0; j <= i; j++)
    {
        Console.WriteLine();
    }
    Console.WriteLine(RocketImg);
    Thread.Sleep(200);
}
Console.WriteLine("The rocket has landed. Woohoo! Another successful landing!");

Console.ReadKey();