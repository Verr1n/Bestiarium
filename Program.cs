

string[] level = {      // Plansza, jeszcze nie wiem jak zrobić ją losowo
    "###########",
    "#      #   #",
    "#   #      #",
    "#   #      #",
    "###########"
};

Console.Clear(); // UWAGA MOKRA PODŁOGA (TU SIĘ SPRZĄTA!!!!)

foreach (string row in level)       // Tutaj wyświetlamy tablice
{
    Console.WriteLine(row);
}

while (true)            //To jest nieskończona pętla tylko po to żeby termninal mi nie znikał, bo inaczej znika mi zanim nawet wyświetli plansze i dupa
{
    Console.ReadLine();
}