//Console.WriteLine("Joonistan sulle kolmnurga");
//int kolmnurgaSuurus = int.Parse(Console.ReadLine());

//int i = 1;
//while(i <= kolmnurgaSuurus)
//{
//    Console.WriteLine();
//    int j = 1;
//    while (j <= i)
//    {
//        Console.Write(j + " ");
//        j++;
//    }
//    i++;
//}

using System.ComponentModel.Design;

Console.WriteLine("Tere tulemast MobiFix parandusautomaati! Kuidas saame aidata?");
Console.WriteLine("0 - headaega \n1- tahan telefoni parandada");
int kasutajaValik = int.Parse(Console.ReadLine());
while (kasutajaValik < 0 && kasutajaValik > 1)
{
    Console.WriteLine("Palun tee valik, vastava arvuga");
    kasutajaValik = int.Parse(Console.ReadLine());
}
if  (kasutajaValik == 0)
{
    Console.WriteLine("Headaega, tulge jälle");
}
else
{
    Console.WriteLine("Missugust telefoni soovid paranda");
    Console.WriteLine("1 - IPhone\n2 - Xiaomi\n3 - Huawei\n4 - Samsung");
    int kasutajaTelefon = int.Parse(Console.ReadLine());
    while (kasutajaTelefon < 1 && kasutajaTelefon > 4)
    {
       kasutajaTelefon = int.Parse(Console.ReadLine()) ;
        Console.WriteLine("Palun tee valik, vastava arvuga");
    }
    switch (kasutajaTelefon)
    {
        case 1:
            Console.WriteLine("Aitäh, oma iPhone saad tagasi 1 nädala pärast");
            break;
        case 2:
            Console.WriteLine("Aitäh, oma iPhone saad tagasi 2 kuu pärast");
            break;
        case 3:
            Console.WriteLine("Kahjuks me huaweid ei teeninda");
            break;
        case 4:
            Console.WriteLine("Teie Samsung saab valmis 2 päeva pärast");
            break;
        default:
            break;
    }
}
