string input, gradeText;
int grade;

Console.Write("Enter a grade: ");
input = Console.ReadLine();
grade = Convert.ToInt32(input);

switch (grade)
{
    case 1:
        gradeText = "Sehr gut";
        break;
    case 2:
        gradeText = "Gut";
        break;
    case 3:
        gradeText = "Befriedigend";
        break;
    case 4:
        gradeText = "Ausreichend";
        break;
    case 5:
        gradeText = "Mangelhaft";
        break;
    case 6:
        gradeText = "Ungenügend";
        break;
    default:
        gradeText = "Invalid grade";
        break;
}

Console.WriteLine("Grade: {0} ({1})", grade, gradeText);
Console.ReadKey();
