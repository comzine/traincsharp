using System;

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

    // Standardkonstruktor für die Deserialisierung
    public MeinObjekt() { }

    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}";
    }

    public bool IstGleich(MeinObjekt obj)
    {
        return Id == obj.Id && Name == obj.Name;
    }
}
