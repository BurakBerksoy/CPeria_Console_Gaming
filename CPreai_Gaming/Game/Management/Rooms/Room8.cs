public class Room8 : Room
{
    public Room8() : base("8", "Karanlık. Zifiri karanlık, hiçbir şey göremiyorsun.")
    {
        InitializeExits();
        Items.Add("P=NP İSPATI");
    }

    public override void InitializeExits()
    {
        Exits["KUZEY"] = "5";
        Exits["BATI"] = "7";
    }
}