using FactoryMalliDemo;

Console.WriteLine("Valitse joko 'auto' tai 'mp':");
string valinta = Console.ReadLine() ?? "";

IAjoneuvo a = AjoneuvoTehdas.LuoUusi(valinta);
a.Käynnistä();
