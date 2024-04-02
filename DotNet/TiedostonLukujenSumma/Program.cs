string[] rivit = File.ReadAllLines("Luvut.txt");

int summa = 0;
foreach (string rivi in rivit)
{
    int luku = int.Parse(rivi);
    summa += luku;
}

Console.WriteLine("Lukujen summa on: " + summa);
Console.WriteLine("Lukujen keskiarvo on: " + summa / rivit.Length);
