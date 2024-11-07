string password;

Console.WriteLine("Enter the length of the password: ");
int length = Convert.ToInt32(Console.ReadLine());

Random rnd = new Random();

for (int i = 0; i < length; i++)
{
    int rndNumber = rnd.Next(0, 62);
    char rndChar = ' ';

    if (rndNumber < 10)
    {
        rndChar = (char)(rndNumber + '0');
    }
    else if (rndNumber < 36)
    {
        rndChar = (char)(rndNumber + 'A' - 10);
    }
    else
    {
        rndChar = (char)(rndNumber + 'a' - 36);
    }

    password += rndChar;
}

Console.WriteLine("Generated password: " + password);
