//Console.WriteLine("For tsükel");

//int kogus = 5;

//for (int i = 0; i < kogus; i++)
//{
//    Console.WriteLine("🍌");
//    Console.Beep();
//}

using System.ComponentModel.DataAnnotations;

//string[] objectArray = new string[5]; //array, massiiv mitmest elemendist
//int objectCount = 0; // loend kui palju kordi küsida
//string temp = "no name"; // muutuja mis hetkel on "tühi"
//while (objectCount < 5) // while tsükkel mis küsib nimesid
//{
//    Console.WriteLine("Sisesta järgmine lemmikloomanimi:");
//    temp = Console.ReadLine(); // temp muutujasse väärtuse (mida me tahame) sisestame
//    objectArray[objectCount] = temp; // massiivi, asukohal objectCount asetame ajutisest muutujast väärtuse
//    objectCount++; // tsükli inkrementatsioon
//}
//Console.WriteLine("Oled sisestanud järgnevad objektid"); // sõnum
//for (int i = 0; i < objectArray.Length; i++)
//{
//    Console.WriteLine($"{i + 1}. element on:  {objectArray[i]}");
//    // kuvame välja reanumbri koos vastava elemendiga, muutuja i abil.
//}
//Console.ReadLine(); //peatame programmi klahvisisestuse taha

string user = "Martin";
string pass = "1234";

Console.WriteLine("Palun sisesta oma nimi: ");
string nimi = Console.ReadLine();
Console.WriteLine("Palun sisesta parool ");
string parool = Console.ReadLine();
if (nimi != user) 
{
    Console.Write("Isik pole registeerunud");
    return;
}
if (parool != pass)
{
    Console.Write($"{nimi} teie parool on vale.");
    return;
}

string[] lemmikloomad = new string[3];
int objectCount = 0;
string tühi = "tühi";
while(objectCount < 3)
{
    Console.WriteLine($"Sisesta oma {objectCount +1} lemmiklooma nimi: ");
    tühi = Console.ReadLine();
    lemmikloomad[objectCount] = tühi;
    objectCount++;
}
Console.WriteLine($"Kokku loomi: {lemmikloomad.Length}");

Console.WriteLine("Milline on sinu lemmikuim loom 1-3?");
int number = int.Parse(Console.ReadLine());

if (number > 0 && number <= lemmikloomad.Length)
{
    string lemmik = lemmikloomad[number -1];
    Console.WriteLine($"Sinu lemmikloom on {lemmik}");
}
