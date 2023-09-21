for (int j = 1; j <= 10; j++)
{
    for (int i = j; i <= j * 10; i += j)
    {
        Console.Write("{0,4}", i);
    }
    Console.WriteLine();
}
