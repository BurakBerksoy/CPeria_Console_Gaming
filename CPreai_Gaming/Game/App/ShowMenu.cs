using System;

public class ShowMenu
{
    public void Menu()
    {
        Transactions transactions = new Transactions();
        transactions.InitializeRooms();  // Odaları başlat
        transactions.PrintRoomDescription();

        while (true)
        {
            Console.Write("Komut girin: ");
            string command = Console.ReadLine().Trim().ToUpper();

            if (command == "KUZEY" || command == "GÜNEY" || command == "DOĞU" || command == "BATI")
            {
                transactions.Move(command);
            }
            else if (command.StartsWith("AL "))
            {
                string item = command.Substring(3).Trim();
                transactions.PickUpItem(item);
            }
            else if (command.StartsWith("AL"))
            {
                Console.WriteLine("Hangi eşyayı alacağını belirtmelisin.");
            }
            else if (command.StartsWith("BIRAK "))
            {
                string item = command.Substring(6).Trim();
                transactions.DropItem(item);
            }
            else if (command.StartsWith("BIRAK"))
            {
                Console.WriteLine("Hangi eşyayı bırakacağını belirtmelisin.");
            }
            else if (command == "SALDIR")
            {
                transactions.Attack();
            }
            else if (command == "ÇIKIŞ")
            {
                transactions.Exit();
            }
            else
            {
                Console.WriteLine("Geçersiz komut.");
            }
        }
    }
}