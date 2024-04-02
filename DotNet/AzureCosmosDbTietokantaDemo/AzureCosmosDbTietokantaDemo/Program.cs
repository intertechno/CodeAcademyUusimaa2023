using Microsoft.Azure.Cosmos;

Console.WriteLine("Aloitetaan Cosmos DB -tietokannan käsittely.");
string yhteysmerkkijono = "AccountEndpoint=https://cosmos2023testi.documents.azure.com:443/;AccountKey=XXXXXXXXX;";
CosmosClient client = new(yhteysmerkkijono);

string tietokannanNimi = "janintietokanta";
var tulos = await client.CreateDatabaseIfNotExistsAsync(tietokannanNimi);

var db = tulos.Database;
string kansionNimi = "omatjutut";
var tulos2 = await db.CreateContainerIfNotExistsAsync(kansionNimi, "/avain");

var container = tulos2.Container;
var uusi = new
{
    id = "janin-testi-1234",
    avain = "testi",
    osoite = "Kotikatu 12 B"
};
var tulos3 = await container.CreateItemAsync(uusi);
Console.WriteLine("Uusi tietue lisätty kantaan!");
