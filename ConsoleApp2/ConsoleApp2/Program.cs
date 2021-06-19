using System;

namespace Cat_House
{
    class Program
    {
        static void Run()
        {
            try
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(); 
                Console.WriteLine();
                Console.Write(new string('║', Console.WindowWidth));
                Console.WriteLine();
                Console.Write(new string(' ', (Console.WindowWidth - "CHOX GOZAL PETI SHOP".Length) / 2));
                Console.WriteLine("CHOX GOZAL PETI SHOP");
                Console.Write(new string('║', Console.WindowWidth));
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(); 
                Console.WriteLine();
                Console.Write(new string('║', Console.WindowWidth));
                Console.WriteLine();
                Console.Write(new string(' ', (Console.WindowWidth - "CHOX GOZAL PETI SHOP 222".Length) / 2));
                Console.WriteLine("CHOX GOZAL PETI SHOP 222");
                Console.Write(new string('║', Console.WindowWidth));
                Console.ResetColor();

                Cat cat1 = new Cat("Kanvass", 6, 400, 10, "male");
                Cat cat2 = new Cat("Toplan", 2, 250, 20, "male");
                Cat cat4 = new Cat("BOB", 6, 400, 10, "male");
                Cat cat5 = new Cat("TUMBO", 2, 250, 20, "male");
                CatHouse catHouse = new CatHouse("CHOX GOZAL PETI SHOP");
                catHouse.AddCat(cat1);
                catHouse.AddCat(cat2);
                CatHouse catHouse2 = new CatHouse("CHOX GOZAL PETI SHOP 222");
                catHouse2.AddCat(cat4);
                catHouse2.AddCat(cat5);
                Cat cat3 = new Cat("Haykanush", 4, 500, 15, "Female");
                catHouse.AddCat(cat3);
                PetShop petShop = new PetShop();
                petShop.AddCatHouse(catHouse);
                petShop.AddCatHouse(catHouse2);
                petShop.Show();
                Console.WriteLine();
                Console.WriteLine($"All Cats Price in Cat Houses: {petShop.GetCatsPriceInTheCatHouses()}");

                //for (int i = 0; i < 12; i++) // Narmalni ishdeyir
                //{
                //cat1.Play();
                //cat1.Eat();
                //}

                //Cat removedCat = catHouse.RemoveByNickName(cat3.NickName); // Narmalni ishdeyir narahat olmayun
                //removedCat.Show();
                //Console.WriteLine();
                //Console.WriteLine();
            }
            catch (InvalidOperationException content)
            {
                Console.WriteLine(content);
            }
        }
        static void Main(string[] args)
        {
            Run();
        }
    }
}
