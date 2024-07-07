public class Room3 : Room
{
    public Room3() : base("3", "Bu odanın tüm duvarlarına tuhaf şekiller çizilmiş ve titreyen meşaleler yüzleri daha da korkutucu hale getiriyor.")
    {
        InitializeExits();
        Items.Add("KALKAN");
    }

    public override void InitializeExits()
    {
        Exits["BATI"] = "2";
    }
}