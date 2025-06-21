using System;

public class NPC
{
    public int X { get; set; }
    public int Y { get; set; }

    private Random rand = new Random();

    public NPC(int x, int y)
    {
        X = x;
        Y = y;
    }

    // NPC porusza się losowo (góra/dół/lewo/prawo)
    public void Move(string[] level)
    {
        int newX = X;
        int newY = Y;

        int dir = rand.Next(4); // 0=góra, 1=dół, 2=lewo, 3=prawo
        switch (dir)
        {
            case 0: newY--; break;
            case 1: newY++; break;
            case 2: newX--; break;
            case 3: newX++; break;
        }

        if (level[newY][newX] != '#')
        {
            X = newX;
            Y = newY;
        }
    }

    public bool Interact()
    {
        Console.Clear();
        Console.WriteLine("NPC: Chcesz się zmierzyć w papier-kamień-nożyce?");
        Console.WriteLine("Masz 3 próby. Wygraj przynajmniej raz, by przejść dalej!");
        Console.WriteLine("Wpisz: papier / kamień / nożyce");

        string[] opcje = { "papier", "kamień", "nożyce" };
        int próby = 3;
        bool wygrana = false;

        while (próby-- > 0)
        {
            Console.Write("\n🫵 Twój wybór: ");
            string gracz = Console.ReadLine()?.ToLower() ?? "";
            string npc = opcje[new Random().Next(3)];

            Console.WriteLine($"NPC wybrał: {npc}");

            if (gracz == npc)
            {
                Console.WriteLine("🔁 Remis!");
            }
            else if ((gracz == "papier" && npc == "kamień") ||
                     (gracz == "kamień" && npc == "nożyce") ||
                     (gracz == "nożyce" && npc == "papier"))
            {
                Console.WriteLine("Wygrałeś!");
                wygrana = true;
                break;
            }
            else
            {
                Console.WriteLine("Przegrałeś tę rundę.");
            }
        }

        return wygrana;
    }
}
