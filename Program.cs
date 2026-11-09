using MuzeumApp;

List<mutargy> gyujtemeny = new List<mutargy>();
int hibas = 0;

foreach(string sor in File.ReadAllLines("mutargyak.txt").Skip(1))
{
    if (string.IsNullOrWhiteSpace(sor))
    {
        hibas++;
        continue;
    }

    string[] darabol = sor.Split("|");
    if (darabol.Count() != 4)
    {
        hibas++;
        continue;
    }
    string tipus = darabol[0].Trim().ToUpper();
    if (tipus != "M" && tipus != "F")
    {
        hibas++;
        continue;
    }
    if (string.IsNullOrWhiteSpace(darabol[1]))
    {
        hibas++;
        continue;
    }
    if (!int.TryParse(darabol[3], out int ertek))
    {
        hibas++;
        continue;
    }
    if (!int.TryParse(darabol[3], out int extra))
    {
        hibas++;
        continue;
    }
    if (tipus == "M") gyujtemeny.Add(new mutargy(darabol[1], ertek));
    else gyujtemeny.Add(new Festmeny(darabol[1], ertek, extra));

   

}
Console.WriteLine($"Sikeresen beolvasott műtárgyak: {gyujtemeny.Count} db");
Console.WriteLine($"Kiszűrt hibás sorok száma: {hibas} db");
Console.WriteLine($"\n Beolvasott műtárgyak listája:");
foreach ( mutargy m in gyujtemeny)
{
    Console.WriteLine(m);
}
Console.WriteLine("\n LINQ Statisztikák:");
double atlag = gyujtemeny.Average(x => x.BecsultErtek);
Console.WriteLine($"Műtárgyak átlagos értéke: {atlag:F0} Ft");
mutargy draga = gyujtemeny.MaxBy(x => x.BecsultErtek);
Console.WriteLine($"Legértékesebb műtárgy: {draga.Azonosito} ({draga.BecsultErtek}) Ft");
