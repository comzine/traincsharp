using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;

/// <summary>
/// Klasse für ein serialisierbares Objekt, das über das Netzwerk gesendet werden kann.
/// </summary>
[Serializable]
public class MeinObjekt
{
    public int Id { get; set; }
    public string Name { get; set; }

    // Konstruktor mit Parametern für die Initialisierung
    public MeinObjekt(int id, string name)
    {
        Id = id;
        Name = name;
    }

    // Standardkonstruktor, notwendig für Deserialisierung
    public MeinObjekt() { }

    // Überschreibt die ToString-Methode für eine bessere Ausgabe
    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}";
    }
}

/// <summary>
/// Hauptklasse des Programms, die sowohl den TCP-Server als auch den TCP-Client steuert.
/// </summary>
class TcpProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wählen Sie den Modus:\n1. Server\n2. Client");
        string modus = Console.ReadLine();

        // Entscheidet, ob das Programm als Server oder Client läuft
        if (modus == "1")
        {
            StarteServer();
        }
        else if (modus == "2")
        {
            StarteClient();
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe.");
        }
        Console.ReadKey();
    }

    /// <summary>
    /// Startet den TCP-Server und wartet auf eingehende Verbindungen.
    /// </summary>
    static void StarteServer()
    {
        Console.WriteLine("Wählen Sie den Serialisierungsmodus:\n1. Binär\n2. JSON");
        string auswahl = Console.ReadLine();

        // Initialisiert und startet den TCP-Server
        var server = new TcpListener(IPAddress.Any, 13000);
        server.Start();
        Console.WriteLine("Server gestartet und wartet auf Verbindungen...");

        // Wartet und akzeptiert eine eingehende Verbindung
        TcpClient client = server.AcceptTcpClient();
        Console.WriteLine("Verbindung akzeptiert.");

        // Erstellt einen Stream für die Kommunikation
        NetworkStream stream = client.GetStream();

        // Verarbeitet die eingehenden Daten basierend auf der gewählten Serialisierungsmethode
        if (auswahl == "1")
        {
            // Binäre Deserialisierung des empfangenen Objekts
            var empfangenesObjekt = new MeinObjekt();
            using (var reader = new BinaryReader(stream, Encoding.UTF8, true))
            {
                empfangenesObjekt.Id = reader.ReadInt32();
                empfangenesObjekt.Name = reader.ReadString();
            }
            Console.WriteLine("Empfangenes Objekt (binär): " + empfangenesObjekt);
        }
        else if (auswahl == "2")
        {
            // JSON Deserialisierung des empfangenen Objekts
            StreamReader reader = new StreamReader(stream);
            string json = reader.ReadToEnd();
            MeinObjekt empfangenesObjekt = JsonSerializer.Deserialize<MeinObjekt>(json);
            Console.WriteLine("Empfangenes Objekt (JSON): " + empfangenesObjekt);
        }

        // Schließt die Verbindung und den Server
        client.Close();
        server.Stop();
    }

    /// <summary>
    /// Startet den TCP-Client und stellt eine Verbindung zum Server her.
    /// </summary>
    static void StarteClient()
    {
        Console.WriteLine("Wählen Sie den Serialisierungsmodus:\n1. Binär\n2. JSON");
        string auswahl = Console.ReadLine();

        // Verbindet sich mit dem Server
        var client = new TcpClient("127.0.0.1", 13000);

        // Erstellt das zu sendende Objekt
        MeinObjekt objektZuSenden = new MeinObjekt(1, "Hallo Server!");
        NetworkStream stream = client.GetStream();

        // Sendet das Objekt an den Server basierend auf der gewählten Serialisierungsmethode
        if (auswahl == "1")
        {
            // Binäre Serialisierung und Senden des Objekts
            using (BinaryWriter writer = new BinaryWriter(stream, Encoding.UTF8, true))
            {
                writer.Write(objektZuSenden.Id);
                writer.Write(objektZuSenden.Name);
            }
            Console.WriteLine("Objekt gesendet (binär): " + objektZuSenden);
        }
        else if (auswahl == "2")
        {
            // JSON Serialisierung und Senden des Objekts
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            using (Utf8JsonWriter writer = new Utf8JsonWriter(stream))
            {
                JsonSerializer.Serialize(writer, objektZuSenden, options);
            }
            Console.WriteLine("Objekt gesendet (JSON): " + JsonSerializer.Serialize(objektZuSenden, options));
        }

        // Schließt die Verbindung
        client.Close();
    }
}
