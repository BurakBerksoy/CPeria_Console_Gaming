public class Room6 : Room
{
    public Room6() : base("6", "Kirle kaplı pencereler, sakin ay ışığı ince şeritler halinde karanlığa nüfuz etmeye çalışıyordu. Keskin gölgeler odanın içinde dolaşıyordu.")
    {
        InitializeExits();
    }

    public override void InitializeExits()
    {
        Exits["BATI"] = "5";
        Exits["GÜNEY"] = "9";
    }
}