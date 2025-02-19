static int InputMask()
{
  string eingabe;
  int mask = 0;
  do
  {
    Console.WriteLine("Geben Sie eine Netzmaske in der slash-Notation ein. Eingabe als reine Zahl. ");
    eingabe = Console.ReadLine();
    mask = 0;
  }
  while (!(int.TryParse(eingabe, out mask) && mask < 32 && mask > 0));
  return mask;
}

static int[] InputIpAddress()
{
  string eingabe;
  int[] ipAddress = new int[4];
  bool isValid = false;
  int richtigeTeile;
  do
  {
    richtigeTeile = 0;
    try
    {
      Console.WriteLine("Bitte geben Sie die IP-Adresse in folgendem Format ein: 192.168.1.23");
      eingabe = Console.ReadLine();
      string[] eingabeTeile = eingabe.Split('.');
      for (int i = 0; i < eingabeTeile.Length; i++)
      {
        ipAddress[i] = int.Parse(eingabeTeile[i]);
        if (ipAddress[i] >= 0 && ipAddress[i] <= 255)
        {
          richtigeTeile++;
        }
      }
      if (richtigeTeile == 4)
      {
        isValid = true;
      }
    }
    catch
    {

    }
  } while (!isValid);
  return ipAddress;
}

static int[] DezimalToDual(int dez)
{
  int[] dual = new int[8];
  int index = 7;
  if (dez > 255)
  {
    Console.WriteLine("Die Zahl ist zu groß.");
    return dual;
  }
  for (int i = 0; i < dual.Length; i++)
  {
    dual[i] = 0;
  }
  while (dez > 0 && index >= 0)
  {
    int rest = dez % 2;
    dual[index] = rest;
    dez = dez / 2;
    index--;
  }
  return dual;
}

static int DualToDezimal(int[] dual)
{
  int dez = 0;
  int wertigkeit = 1;
  for (int i = dual.Length - 1; i >= 0; i--)
  {
    dez = dez + dual[i] * wertigkeit;
    wertigkeit = wertigkeit * 2;
  }
  return dez;
}

static int[] CalculateNetworkAddress(int[] ipAddress, int mask)
{
  /*
  mask      |   ipAddress[i]
  0-7       |       i=0        
  8-15      |       i=1
  16-23     |       i=2
  24-31     |       i=3
  i = mask / 8

  mask      |    bit index j
  16        |     0
  17        |     1
  19        |     3
  21        |     5
  23        |     7
  j = mask % 8

  Bei Netzmaske "mask" werden alle Bits ab dem ipAddress-Teil mit dem Index i an der Dualzahlstelle mit dem Index j zu 0 gesetzt.
  */

  int[] dualIpAddressTeil = DezimalToDual(ipAddress[mask / 8]);
  for (int j = mask % 8; j < 8; j++)
  {
    dualIpAddressTeil[j] = 0;
  }
  int dezIpAddressTeil = DualToDezimal(dualIpAddressTeil);
  ipAddress[mask / 8] = dezIpAddressTeil;

  // Alle nachfolgenden IpAddress-Teile auf null setzen
  for (int i = mask / 8 + 1; i < 4; i++)
  {
    ipAddress[i] = 0;
  }
  return ipAddress;
}

static int[] CalculateBroadcastAddress(int[] ipAddress, int mask)
{
  int[] dualIpAddressTeil = DezimalToDual(ipAddress[mask / 8]);
  for (int j = mask % 8; j < 8; j++)
  {
    dualIpAddressTeil[j] = 1;
  }
  int dezIpAddressTeil = DualToDezimal(dualIpAddressTeil);
  ipAddress[mask / 8] = dezIpAddressTeil;

  for (int i = mask / 8 + 1; i < 4; i++)
  {
    ipAddress[i] = 255;
  }
  return ipAddress;
}

static bool CheckSameNetwork(int[] ipAddress1, int[] ipAddress2, int mask)
{
  bool sameNetwork = true;
  int[] netAddress1 = CalculateNetworkAddress(ipAddress1, mask);
  int[] netAddress2 = CalculateNetworkAddress(ipAddress2, mask);
  for (int i = 0; i < netAddress1.Length; i++)
  {
    if (netAddress1[i] != netAddress2[i])
    {
      sameNetwork = false;
    }
  }
  return sameNetwork;
}

static int[] FirstIpAddress(int[] ipAddress, int mask)
{
  int[] netAddress = CalculateNetworkAddress(ipAddress, mask);
  netAddress[3] += 1;
  return netAddress;
}

static int[] LastIpAddress(int[] ipAddress, int mask)
{
  int[] bcAddress = CalculateBroadcastAddress(ipAddress, mask);
  bcAddress[3] -= 1;
  return bcAddress;
}

static int NumberOfHosts(int mask)
{
  return (int)Math.Pow(2, 32 - mask) - 2;
}




int[] ipAddress = InputIpAddress();
int mask = InputMask();
int[] netAddress = CalculateNetworkAddress(ipAddress, mask);
int[] bcAddress = CalculateBroadcastAddress(ipAddress, mask);

Console.WriteLine(string.Join('.', ipAddress) + '/' + mask);
Console.WriteLine($"Netzadresse: {string.Join('.', netAddress)}");
Console.WriteLine($"Broadcastaddresse: {string.Join('.', bcAddress)}");
Console.WriteLine($"Erste IP-Adresse: {string.Join('.', FirstIpAddress(ipAddress, mask))}");
Console.WriteLine($"Letzte IP-Adresse: {string.Join('.', LastIpAddress(ipAddress, mask))}");
Console.WriteLine($"Anzahl der Hosts: {NumberOfHosts(mask)}");
Console.WriteLine("Geben Sie eine weitere IP-Adresse ein, um zu prüfen, ob sie sich im selben Netzwerk befindet.");
int[] ipAddress2 = InputIpAddress();
if (CheckSameNetwork(ipAddress, ipAddress2, mask))
{
  Console.WriteLine("Die beiden IP-Adressen befinden sich im selben Netzwerk.");
}
else
{
  Console.WriteLine("Die beiden IP-Adressen befinden sich nicht im selben Netzwerk.");
}