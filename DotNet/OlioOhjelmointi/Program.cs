using System.Text.Json;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<Henkilö> henkilöt = new() {
    new() {
        Nimi = "Jaska Jokunen",
        Sähköposti = "jaska@jokuset.fi"
    },
    new() {
        Nimi = "Maija Meikäläinen",
        Sähköposti = "maija@kotinetti.fi"
    }
};

string json = JsonSerializer.Serialize(henkilöt);
File.WriteAllText("Henkilöt.json", json);

/*
List<Henkilö> henkilöt = new();

Henkilö h = new();
h.Nimi = "Jaska Jokunen";
h.Sähköposti = "jaska@jokuset.fi";

henkilöt.Add(h);

// toinen henkilö
h = new();
h.Nimi = "Maija Meikäläinen";
h.Sähköposti = "maija@kotinetti.fi";

henkilöt.Add(h);
*/
