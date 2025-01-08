using BarlangokCLI;
using System.Security.Cryptography.X509Certificates;
using System.Text;

const string SOLDIR = "H:\\repos\\Barlangok\\src";

List<Barlang> barlangok = new();

using (StreamReader sr = new($"{SOLDIR}\\barlangok.txt", Encoding.UTF8))
{
    _ = sr.ReadLine();
    while (!sr.EndOfStream)
    {
        Barlang b = new(sr.ReadLine());
        barlangok.Add(b);
    }
}

Console.WriteLine(barlangok.Count);

var miskolciAvg = barlangok.Where(b => b.Telepules.StartsWith("Miskolc")).Average(b => b.Melyseg);

Console.WriteLine($"{miskolciAvg:0.000}");

Console.WriteLine("Adj meg egy védettségi szintet");
string input = Console.ReadLine();

Barlang vedettseg = barlangok.FindAll(x => x.Vedettseg == input).OrderByDescending(x => x.Hossz).First();

Console.WriteLine($"Név: {vedettseg.Nev}\nAzonosító: {vedettseg.Azon}\nTelepülés: {vedettseg.Telepules}\nHossz: {vedettseg.Hossz} m\nMélység: {vedettseg.Melyseg} m");


Dictionary<string, int> vedettsegStat = new();

var f7grp = barlangok.GroupBy(x => x.Vedettseg);

foreach (var grp in f7grp)
{
    Console.WriteLine($"\t{grp.Key,-30}:".Replace(" ", "-") + $" {grp.Count(), 3} db");

}

