using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

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
}

class Program
{
    static void Main(string[] args)
    {
        var meinObjekt = new MeinObjekt(1, "TestObjekt");

        // Binäre Serialisierung und Deserialisierung
        string binareDateipfad = "meinObjekt.dat";
        BinareSerialisierungInDatei(meinObjekt, binareDateipfad);
        MeinObjekt binarDeserialisiertesObjekt = BinareDeserialisierungAusDatei(binareDateipfad);

        // JSON-Serialisierung und Deserialisierung
        string jsonDateipfad = "meinObjekt.json";
        JsonSerialisierungInDatei(meinObjekt, jsonDateipfad);
        MeinObjekt jsonDeserialisiertesObjekt = JsonDeserialisierungAusDatei(jsonDateipfad);
    }

    static void BinareSerialisierungInDatei(MeinObjekt obj, string dateipfad)
    {
        string jsonString = JsonSerializer.Serialize(obj);
        File.WriteAllText(dateipfad, jsonString);
        Console.WriteLine("Objekt binär in Datei serialisiert: " + dateipfad);
    }

    static MeinObjekt BinareDeserialisierungAusDatei(string dateipfad)
    {
        using (var stream = new FileStream(dateipfad, FileMode.Open))
        {
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
            MeinObjekt obj = JsonSerializer.DeserializeAsync<MeinObjekt>(stream, options).Result;
            Console.WriteLine("Objekt aus binärer Datei deserialisiert.");
            return obj;
        }
    }

    static void JsonSerialisierungInDatei(MeinObjekt obj, string dateipfad)
    {
        string jsonString = JsonSerializer.Serialize(obj);
        File.WriteAllText(dateipfad, jsonString);
        Console.WriteLine("Objekt als JSON in Datei serialisiert: " + dateipfad);
    }

    static MeinObjekt JsonDeserialisierungAusDatei(string dateipfad)
    {
        string jsonString = File.ReadAllText(dateipfad);
        MeinObjekt obj = JsonSerializer.Deserialize<MeinObjekt>(jsonString);
        Console.WriteLine("Objekt aus JSON-Datei deserialisiert.");
        return obj;
    }
}
