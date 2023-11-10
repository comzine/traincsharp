int day, month, year;

System.Console.WriteLine("Please enter a day:");
day = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("Please enter a month:");
month = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("Please enter a year:");
year = Convert.ToInt32(System.Console.ReadLine());

bool isLeapYear = false;
if (year % 400 == 0)
{
    isLeapYear = true;
}
else if (year % 100 == 0)
{
    isLeapYear = false;
}
else if (year % 4 == 0)
{
    isLeapYear = true;
}

bool isValidDate = false;

switch (month)
{
    case 1:
    case 3:
    case 5:
    case 7:
    case 8:
    case 10:
    case 12:
        if (day >= 1 && day <= 31)
        {
            isValidDate = true;
        }
        break;
    case 4:
    case 6:
    case 9:
    case 11:
        if (day >= 1 && day <= 30)
        {
            isValidDate = true;
        }
        break;
    case 2:
        if (isLeapYear)
        {
            if (day >= 1 && day <= 29)
            {
                isValidDate = true;
            }
        }
        else
        {
            if (day >= 1 && day <= 28)
            {
                isValidDate = true;
            }
        }
        break;
    default:
        isValidDate = false;
        break;
}

if (isValidDate)
{
    Console.WriteLine("Das eingegebene Datum ist gültig.");
}
else
{
    Console.WriteLine("Das eingegebene Datum ist ungültig.");
}

Console.ReadKey();