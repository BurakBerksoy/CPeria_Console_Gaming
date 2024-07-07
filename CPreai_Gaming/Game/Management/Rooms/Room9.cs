public class Room9 : Room
{
    public Room9() : base("9", "Karanlık ağır, duvarlar kalın ve yakın geliyor.")
    {
        InitializeExits();
    }

    public override void InitializeExits()
    {
        Exits["DOĞU"] = "FİNİSH";
    }
}