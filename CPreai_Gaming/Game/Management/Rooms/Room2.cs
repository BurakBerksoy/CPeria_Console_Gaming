public class Room2 : Room
{
    public Room2() : base("2", "Soğuk, tereddütlü ışık çatlak bir pencereden içeri giriyor ve duvarlarda ürkütücü gölgeler oluşturuyor.")
    {
        InitializeExits();
    }

    public override void InitializeExits()
    {
        Exits["BATI"] = "1";
        Exits["DOĞU"] = "3";
        Exits["GÜNEY"] = "5";
    }
}