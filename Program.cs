
var shop = new mag_toy("Магазин", 3);

Console.WriteLine($"старт: Count={shop.Count}, Toys=[{shop.Get_Info()}]");
Console.WriteLine("\n");

        Console.WriteLine(shop.Add_toy("Minecraft", 2));
        Console.WriteLine($"  Count={shop.Count}, Toys=[{shop.Get_Info()}]");
Console.WriteLine("\n");

        Console.WriteLine(shop.Add_toy("Tetris", 1));
        Console.WriteLine($"  Count={shop.Count}, Toys=[{shop.Get_Info()}]");
Console.WriteLine("\n");

        Console.WriteLine(shop.Buy_game("Minecraft"));
        Console.WriteLine($"  Count={shop.Count}, Toys=[{shop.Get_Info()}]");
Console.WriteLine("\n");

        Console.WriteLine(shop.Get_Info());
Console.WriteLine("\n");

        shop.Close();
        Console.WriteLine(shop.Buy_game("Tetris"));