int numberOfPrisoners = 100;

Console.WriteLine("Input number of prisoners: ");
numberOfPrisoners = Convert.ToInt32(Console.ReadLine());

bool[] prisonGates = new bool[numberOfPrisoners];

// initial state: all doors closed (false)
for (int i = 0; i < prisonGates.Length; i++)
{
    prisonGates[i] = false;
}

// Initial state: all doors closed (false)
for (int pass = 1; pass <= numberOfPrisoners; pass++)
{
    for (int door = pass - 1; door < prisonGates.Length; door += pass)
    {
        prisonGates[door] = !prisonGates[door];
    }
}

// Count open doors
int openDoors = 0;

for (int i = 0; i < prisonGates.Length; i++)
{
    if (prisonGates[i])
    {
        openDoors++;
    }
}

Console.WriteLine($"Number of open doors: {openDoors}");

// output open doors

for (int i = 0; i < prisonGates.Length; i++)
{
    if (prisonGates[i])
    {
        Console.WriteLine($"Door {i + 1} is open");
    }
}
