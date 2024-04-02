using Azure.Storage.Blobs;
using System.Text;

Console.WriteLine("Aloitetaan Azure Blob Storagen käsittely.");

// TODO: parempi oli tallentaa nämä erilliseen tiedostoon
string connection = "DefaultEndpointsProtocol=https;AccountName=codeacademyuusimaa;AccountKey=XXXXXXXXX;EndpointSuffix=core.windows.net";
string container = "janin-jutut";

BlobContainerClient client = new(connection, container);
//client.Create();
//Console.WriteLine("Container muodostettu.");

BlobClient blob = client.GetBlobClient("eka-blobbi.txt");
string message = "Moikka Azure!";
byte[] bytes = Encoding.UTF8.GetBytes(message);
MemoryStream stream = new(bytes);
blob.Upload(stream);

Console.WriteLine("Uusi blob lisätty!");
