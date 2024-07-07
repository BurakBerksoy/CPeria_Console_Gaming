public class Room4 : Room
{
    public Room4() : base("4", "Rüzgâr uğultulu ve uğultulu perdeler soğuk esintiyle titriyor ve döşeme tahtaları sinirli bir enkaz gibi huzursuzca gıcırdıyordu.")
    {
        InitializeExits();
        Items.Add("ALTIN KADEH");
    }

    public override void InitializeExits()
    {
        Exits["KUZEY"] = "1";
    }
}