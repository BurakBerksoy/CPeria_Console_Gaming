public class Room1 : Room
{
    public Room1() : base("1", "Omurganızdan aşağıya serin bir ürperti iniyor. Etrafınıza endişeyle baktığınızda, toz katmanlarının arkasından size bakan, görünüşe göre varlığınıza nüfuz eden kasvetli portreler görüyorsunuz. Kalenin Çıkışı Batınızadır.")
    {
        InitializeExits();
    }

    public override void InitializeExits()
    {
        Exits["BATI"] = "ÇIKIŞ";
        Exits["DOĞU"] = "2";
        Exits["GÜNEY"] = "4";
    }
}