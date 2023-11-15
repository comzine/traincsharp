using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        var meinObjekt = new MeinObjekt(1, "TestObjekt");

        // Binäre Serialisierung und Deserialisierung
        string binareDateipfad = "meinObjekt.dat";
        BinareSerialisierungInDatei(meinObjekt, binareDateipfad);
        var meinBinObjekt = BinareDeserialisierungAusDatei(binareDateipfad);
        if (meinObjekt.IstGleich(meinBinObjekt))
            Console.WriteLine("BinObjekt ist gleich.");
        else
            Console.WriteLine("BinObjekt ist nicht gleich.");

        // JSON Serialisierung und Deserialisierung
        string jsonDateipfad = "meinObjekt.json";
        JsonSerialisierungInDatei(meinObjekt, jsonDateipfad);
        var meinJsonObjekt = JsonDeserialisierungAusDatei(jsonDateipfad);
        if (meinObjekt.IstGleich(meinJsonObjekt))
            Console.WriteLine("JsonObjekt ist gleich.");
        else
            Console.WriteLine("JsonObjekt ist nicht gleich.");
        Console.ReadKey();
    }

    static void BinareSerialisierungInDatei(MeinObjekt obj, string dateipfad)
    {
        using (Stream stream = File.Open(dateipfad, FileMode.Create))
        {
            using (BinaryWriter writer = new BinaryWriter(stream))
            {
                writer.Write(obj.Id);
                writer.Write(obj.Name);
            }
        }
        Console.WriteLine("Objekt binär in Datei serialisiert: " + dateipfad);
    }

    static MeinObjekt BinareDeserialisierungAusDatei(string dateipfad)
    {
        using (Stream stream = File.Open(dateipfad, FileMode.Open))
        {
            using (BinaryReader reader = new BinaryReader(stream))
            {
                int id = reader.ReadInt32();
                string name = reader.ReadString();
                MeinObjekt obj = new MeinObjekt(id, name);
                Console.WriteLine("Objekt aus binärer Datei deserialisiert.");
                return obj;
            }
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
