double maxPoints, points = 0;
double grade;

do {
    Console.Write("Enter the maximum points: ");
} while (!double.TryParse(Console.ReadLine(), out maxPoints));

while (points >= 0)
{
    do {
        Console.Write("Enter the points: ");
    } while (!double.TryParse(Console.ReadLine(), out points));

    if (points < 0)
        break;

    grade = 6.0 - 5.0 * points / maxPoints;

    Console.WriteLine("Grade: {0:F1}", grade);
}