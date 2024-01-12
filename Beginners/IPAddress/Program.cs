int[] ipAddress = new int[4];
System.Console.WriteLine("Enter an IP address in four parts:");
ipAddress[0] = int.Parse(System.Console.ReadLine());
ipAddress[1] = int.Parse(System.Console.ReadLine());
ipAddress[2] = int.Parse(System.Console.ReadLine());
ipAddress[3] = int.Parse(System.Console.ReadLine());
System.Console.WriteLine($"You entered {ipAddress[0]}.{ipAddress[1]}.{ipAddress[2]}.{ipAddress[3]}");
int subnetSize = 0;
System.Console.WriteLine("Enter the subnet size:");
subnetSize = int.Parse(System.Console.ReadLine());
System.Console.WriteLine($"Enter the second IP address:");
string[] secondIPStrings = System.Console.ReadLine().Split('.');
int[] secondIP = new int[4];
for (int i = 0; i < 4; i++)
{
  secondIP[i] = int.Parse(secondIPStrings[i]);
}

string[] firstIpAddressBinary = ConvertIPtoBinary(ipAddress);
string[] secondIpAddressBinary = ConvertIPtoBinary(secondIP);


System.Console.WriteLine($"The binary version of your IP address is {firstIpAddressBinary[0]}.{firstIpAddressBinary[1]}.{firstIpAddressBinary[2]}.{firstIpAddressBinary[3]}");
System.Console.WriteLine($"The binary version of your second IP address is {secondIpAddressBinary[0]}.{secondIpAddressBinary[1]}.{secondIpAddressBinary[2]}.{secondIpAddressBinary[3]}");

bool selbesNetz = SindIpAdressenImGleichenNetz(firstIpAddressBinary, secondIpAddressBinary, subnetSize);
if(selbesNetz)
{
  System.Console.WriteLine("Die IP Adressen sind im selben Netz.");
}
else
{
  System.Console.WriteLine("Die IP Adressen sind nicht im selben Netz.");
}

static string[] ConvertIPtoBinary(int[] ip)
{
  string[] binary = new string[4];
  for (int i = 0; i < 4; i++)
  {
    int ipTemp = ip[i];
    binary[i] = "";
    for (int j = 0; j < 8; j++)
    {
      binary[i] = (ipTemp % 2) + binary[i];
      ipTemp = ipTemp / 2;
    }
  }

  return binary;
}

static bool SindIpAdressenImGleichenNetz(string[] ipAdresse1, string[] ipAdresse2, int groesse)
{
  bool gleichesNetz = true;
  for(int i = 0; i < groesse; i++)
  {
    int bereich = i / 8;
    int index = i % 8;
    if (ipAdresse1[bereich][index] != ipAdresse2[bereich][index])
    {
      gleichesNetz = false;
      break;
    }
  }
  return gleichesNetz;
}





// example output
// Enter an IP address in four parts:
// 192
// 168
// 1
// 1
// 11100000.10101000.00000001.00000001
// 11000000.10101000.00000001.00000001

// 192.168.1.1/24