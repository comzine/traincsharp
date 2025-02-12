static int[] InputIpAddress()
{
  int[] ip = new int[4];
  Console.WriteLine("Enter IP address:");
  string[] ipString = Console.ReadLine().Split('.');
  for (int i = 0; i < 4; i++)
  {
    ip[i] = int.Parse(ipString[i]);
  }
  return ip;
}

static int InputMask()
{
  Console.WriteLine("Enter mask (for /24 enter 24):");
  return int.Parse(Console.ReadLine());
}

static int[] DezimalToDual(int dezimal)
{
  int[] dual = new int[8];
  for (int i = 7; i >= 0; i--)
  {
    dual[i] = dezimal % 2;
    dezimal /= 2;
  }
  return dual;
}

static int DualToDezimal(int[] dual)
{
  int dezimal = 0;
  for (int i = 0; i < dual.Length; i++)
  {
    dezimal += dual[i] * (int)Math.Pow(2, dual.Length - 1 - i);
  }
  return dezimal;
}
static int[] CalculateNetworkAddress(int[] ipAddress, int mask)
{
  int[] networkAddress = new int[4];
  for (int i = 0; i < 4; i++)
  {
    int[] dual = DezimalToDual(ipAddress[i]);
    for (int j = 0; j < 8; j++)
    {
      if (8 * i + j >= mask)
      {
        dual[j] = 0;
      }
    }
    networkAddress[i] = DualToDezimal(dual);
  }
  return networkAddress;
}

static int[] CalculateBroadcastAddress(int[] ipAddress, int mask)
{
  int[] broadcastAddress = new int[4];
  for (int i = 0; i < 4; i++)
  {
    int[] dual = DezimalToDual(ipAddress[i]);
    for (int j = 0; j < 8; j++)
    {
      if (8 * i + j >= mask)
      {
        dual[j] = 1;
      }
    }
    broadcastAddress[i] = DualToDezimal(dual);
  }
  return broadcastAddress;
}


int[] ipAddress = InputIpAddress();
int mask = InputMask();
int[] networkAddress = CalculateNetworkAddress(ipAddress, mask);
int[] broadcastAddress = CalculateBroadcastAddress(ipAddress, mask);
Console.WriteLine("Network address: " + string.Join(".", networkAddress));
Console.WriteLine("Broadcast address: " + string.Join(".", broadcastAddress));