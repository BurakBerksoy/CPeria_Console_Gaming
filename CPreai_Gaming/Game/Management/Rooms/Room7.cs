public class Room7 : Room
{
    public Room7() : base("7", "Ateş öldü. Oda soğuk, uyanık ve baş zonkluyor. Görüş bulanık.")
    {
        InitializeExits();
        Items.Add("HANÇER");
    }

    public override void InitializeExits()
    {
        Exits["DOĞU"] = "8";
    }
}