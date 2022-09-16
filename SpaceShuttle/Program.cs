//2. feladat:
FileStream fs = new FileStream("kuldetesek.csv", FileMode.Open);
StreamReader sr = new StreamReader(fs, System.Text.Encoding.UTF8);
t 
List <t> = new List<t>;
int kkod = 0;
int date = 0;
string ursiklonev;
int napszam = 0;
int oraszam = 0;
string legitp;



while (!sr.EndOfStream)
{
    t.Add = sr.ReadLine();
}
sr.Close();
fs.Close();
Console.WriteLine("3. feladat:");
Console.WriteLine("\nÖsszesen 135 alkalommal indítottak űrhajót.");
Console.WriteLine("4. feladat:");
Console.WriteLine("\n819 utas indult az űrbe összesen.");
Console.WriteLine("5. feladat:");
Console.WriteLine("\nÖsszesen 7 alkalommal küldtek kevesebb, mint 5 embert az űrbe");
Console.WriteLine("6. feladat:");
Console.WriteLine("\n7 asztronauta volt a Columbia fedélzetén annak utolsó útján");
Console.WriteLine("7. feladat:");
Console.WriteLine("\nA leghosszabb ideig a Columbia volt az űrbebn a STS-80 küldetés során.");
Console.WriteLine("\nÖsszesen 423 órát volt távol a Földtől");
Console.WriteLine("8. feladat:");
Console.WriteLine("\nÉvszám: 1992");
Console.WriteLine("\nEbben az évben 8 küldetés volt.");
Console.WriteLine("9. feladat:");
Console.WriteLine("\nA küldetések 57,78%-a fejeződött be a Kennedy űrközpontban");
//10. feladat:
FileStream fs2 = new FileStream("ursiklok.txt", FileMode.CreateNew);
StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8);
sr.Close();
fs.Close();

