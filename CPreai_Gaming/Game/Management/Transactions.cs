using System;
using System.Collections.Generic;

public class Transactions
{
    private string currentRoom = "1";
    private List<string> inventory = new List<string>();
    private Dictionary<string, Room> rooms = new Dictionary<string, Room>();
    private bool medusaDead = false;
    private bool draculaDead = false;
    private bool princessRescued = false;

    public void InitializeRooms()
    {
        rooms["1"] = new Room1();
        rooms["2"] = new Room2();
        rooms["3"] = new Room3();
        rooms["4"] = new Room4();
        rooms["5"] = new Room5();
        rooms["6"] = new Room6();
        rooms["7"] = new Room7();
        rooms["8"] = new Room8();
        rooms["9"] = new Room9();
    }

    public void PrintRoomDescription()
    {
        Room room = rooms[currentRoom];
        Console.WriteLine(room.Description);
        foreach (var exit in room.Exits)
        {
            if (exit.Value != null)
                Console.WriteLine($" {exit.Key}ya bir kapı var.");
        }

        if (room.Items.Count > 0)
            Console.WriteLine("Eşyalar: " + string.Join(", ", room.Items));

        if (currentRoom == "5" && !medusaDead)
            Console.WriteLine("Medusa kilitli bir kapının yanında seni öldürmek için bekliyor.");
        else if (currentRoom == "6" && !draculaDead)
            Console.WriteLine("Dracula odanın içinde karanlıkta bekliyor.");
        else if (currentRoom == "9")
            Console.WriteLine("Prenses Zelda burada.");
    }

    public void Move(string direction)
    {
        Room room = rooms[currentRoom];
        var upperDirection = direction.ToUpper();
        if (room.Exits.ContainsKey(upperDirection) && room.Exits[upperDirection] != null)
        {
            currentRoom = room.Exits[upperDirection];
            Console.WriteLine($"Şuan {currentRoom} odasındasınız.");
            PrintRoomDescription();
        }
        else
        {
            Console.WriteLine("Geçersiz komut. Lütfen geçerli bir yön girin: KUZEY, GÜNEY, DOĞU, BATI");
        }
    }

    public void PickUpItem(string item)
    {
        Room room = rooms[currentRoom];
        if (room.Items.Contains(item))
        {
            if (inventory.Count < 10)
            {
                inventory.Add(item);
                room.Items.Remove(item);
                Console.WriteLine($"{item} alındı.");
            }
            else
            {
                Console.WriteLine("Çantanız dolu.");
            }
        }
        else
        {
            Console.WriteLine("Bu eşya burada yok.");
        }
    }

    public void DropItem(string item)
    {
        Room room = rooms[currentRoom];
        if (inventory.Contains(item))
        {
            inventory.Remove(item);
            room.Items.Add(item);
            Console.WriteLine($"{item} bırakıldı.");
        }
        else
        {
            Console.WriteLine("Bu eşya çantanızda yok.");
        }
    }

    public void Attack()
    {
        Room room = rooms[currentRoom];
        if (currentRoom == "5" && !medusaDead)
        if (currentRoom == "5" && !medusaDead)
        {
            if (inventory.Contains("KALKAN"))
            {
                medusaDead = true;
                room.Exits["DOĞU"] = "8"; // Medusa öldüğünde odalar arasında geçit açılır
                Console.WriteLine("Medusa öldü. Oda 5 ile oda 8 arasındaki geçit açıldı.");
            }
            else
            {
                Console.WriteLine("Medusa tarafından öldürüldünüz.");
                Console.WriteLine("Yani artık canavar tarafından öldürüldün. Artık tüm umutlar kaybolmuştur. Karanlık hakimdir ve Prenses'in yasları kalenin karanlığında yankılanmaktadır. Prensesi hayal kırıklığına uğrattın. Artık her şey kaybolmuştur. Güle güle. Kaybettin.");
                Environment.Exit(0);
            }
        }
        else if (currentRoom == "6" && !draculaDead)
        {
            if (inventory.Contains("HANÇER"))
            {
                draculaDead = true;
                room.Exits["GÜNEY"] = "9"; // Dracula öldüğünde odalar arasında geçit açılır
                Console.WriteLine("Dracula öldü. Oda 6 ile oda 9 arasındaki geçit açıldı.");
            }
            else
            {
                Console.WriteLine("Dracula tarafından öldürüldünüz.");
                Console.WriteLine("Yani artık canavar tarafından öldürüldün. Artık tüm umutlar kaybolmuştur. Karanlık hakimdir ve Prenses'in yasları kalenin karanlığında yankılanmaktadır. Prensesi hayal kırıklığına uğrattın. Artık her şey kaybolmuştur. Güle güle. Kaybettin.");
                Environment.Exit(0);
            }
        }
        else
        {
            Console.WriteLine("Burada saldırılacak bir canavar yok.");
        }
        }

public void Exit()
{
    if (currentRoom == "1")
    {
        if (princessRescued)
            Console.WriteLine("Tebrikler. Başardınız! Prenses kurtarıldı ve güçlü XPeria Krallığı kurtarıldı!");
        else
            Console.WriteLine("Kaybettiniz. Prenses olmadan kaleden kaçtınız.");
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Çıkışa ulaşmanız gerekiyor.");
    }
}
}