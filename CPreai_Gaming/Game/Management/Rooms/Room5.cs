public class Room5 : Room
{
    public Room5() : base("5", "Gıcırdayan kapılar, gıcırdayan döşeme tahtaları, toz tavşanları ve örümcek ağları, gölgeler ve ürkütücü sesler, hepsi bu odada sizi bekliyor.")
    {
        InitializeExits();
    }

    public override void InitializeExits()
    {
        Exits["KUZEY"] = "2";
        Exits["DOĞU"] = "6";
        Exits["GÜNEY"] = "8";
    }
}