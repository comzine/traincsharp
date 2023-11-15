using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

[Serializable]
public class MeinObjekt
{
    public int Id { get; set; }
    public string Name { get; set; }

    public MeinObjekt(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public MeinObjekt() { }

    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}";
    }
}

class TcpProgram
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Wählen Sie den Modus:\n1. Server\n2. Client");
        string modus = Console.ReadLine();

        if (modus == "1")
        {
            StarteServerAsync();
        }
        else if (modus == "2")
        {
            StarteClientAsync();
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe.");
        }
        int i = 0;
        while (true)
        {
            if (i > 10)
            {
                Console.WriteLine("working ...");
            }
            await Task.Delay(1000);
            i++;
        }
        Console.ReadKey();
    }

    static async Task StarteServerAsync()
    {
        Console.WriteLine("Wählen Sie den Serialisierungsmodus:\n1. Binär\n2. JSON");
        string auswahl = Console.ReadLine();

        var server = new TcpListener(IPAddress.Any, 13000);
        server.Start();
        Console.WriteLine("Server gestartet und wartet auf Verbindungen...");

        while (true)
        {
            TcpClient client = await server.AcceptTcpClientAsync();
            Console.WriteLine("Verbindung akzeptiert.");
            HandleClientAsync(client, auswahl);
        }
    }

    static async Task HandleClientAsync(TcpClient client, string auswahl)
    {
        NetworkStream stream = client.GetStream();

        if (auswahl == "1")
        {
            BinaryReader reader = new BinaryReader(stream);
            int id = reader.ReadInt32();
            string name = reader.ReadString();
            MeinObjekt empfangenesObjekt = new MeinObjekt(id, name);
            Console.WriteLine("Empfangenes Objekt (binär): " + empfangenesObjekt);
        }
        else if (auswahl == "2")
        {
            StreamReader reader = new StreamReader(stream);
            string json = await reader.ReadToEndAsync();
            MeinObjekt empfangenesObjekt = JsonSerializer.Deserialize<MeinObjekt>(json);
            Console.WriteLine("Empfangenes Objekt (JSON): " + empfangenesObjekt);
        }

        client.Close();
    }

    static async Task StarteClientAsync()
    {
        Console.WriteLine("Wählen Sie den Serialisierungsmodus:\n1. Binär\n2. JSON");
        string auswahl = Console.ReadLine();

        var client = new TcpClient();
        await client.ConnectAsync("127.0.0.1", 13000);

        MeinObjekt objektZuSenden = new MeinObjekt(1, "Hallo Server!");
        NetworkStream stream = client.GetStream();

        if (auswahl == "1")
        {
            BinaryWriter writer = new BinaryWriter(stream);
            writer.Write(objektZuSenden.Id);
            writer.Write(objektZuSenden.Name);
            Console.WriteLine("Objekt gesendet (binär): " + objektZuSenden);
        }
        else if (auswahl == "2")
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            using (Utf8JsonWriter writer = new Utf8JsonWriter(stream))
            {
                JsonSerializer.Serialize(writer, objektZuSenden, options);
            }
            Console.WriteLine("Objekt gesendet (JSON): " + JsonSerializer.Serialize(objektZuSenden, options));
        }

        client.Close();
    }
}
