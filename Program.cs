

string[] level = {
    "###########",
    "#      #   #",
    "#   #      #",
    "#   #      #",
    "###########"
};

Console.Clear();

foreach (string row in level)
{
    Console.WriteLine(row);
}

while (true)
{
    Console.ReadLine();
}