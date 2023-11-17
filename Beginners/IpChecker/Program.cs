string input;

int ipPart1 = 0, ipPart2 = 0, ipPart3 = 0, ipPart4 = 0;

bool valid = true;

Console.Write("Enter an IP address: ");
input = Console.ReadLine();

string tmp = "";
int part = 1;
try
{
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == '.')
        {
            switch (part)
            {
                case 1:
                    ipPart1 = Convert.ToInt32(tmp);
                    break;
                case 2:
                    ipPart2 = Convert.ToInt32(tmp);
                    break;
                case 3:
                    ipPart3 = Convert.ToInt32(tmp);
                    break;
                case 4:
                    ipPart4 = Convert.ToInt32(tmp);
                    break;
            }
            tmp = "";
            part++;
        }
        else
        {
            tmp += input[i];
        }
    }
}
catch
{
    valid = false;
}
if (ipPart1 > 255 || ipPart2 > 255 || ipPart3 > 255 || ipPart4 > 255)
{
    valid = false;
}
if (ipPart1 < 0 || ipPart2 < 0 || ipPart3 < 0 || ipPart4 < 0)
{
    valid = false;
}
string output = "";
if (valid)
{
    output = "valid";
}
else
{
    output = "invalid";
}
Console.WriteLine("IP Address: {0} is {1}", input, output);
Console.ReadKey();