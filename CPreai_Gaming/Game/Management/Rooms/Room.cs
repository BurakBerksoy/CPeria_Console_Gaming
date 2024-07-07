using System.Collections.Generic;

public abstract class Room
{
    public string Id { get; }
    public string Description { get; }
    public List<string> Items { get; set; }
    public Dictionary<string, string> Exits { get; set; }

    protected Room(string id, string description)
    {
        Id = id;
        Description = description;
        Items = new List<string>();
        Exits = new Dictionary<string, string>();
    }

    public abstract void InitializeExits();
}