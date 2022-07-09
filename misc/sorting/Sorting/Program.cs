namespace StringFormatting;

public class Program
{
    public static void Main(string[] args)
    {
        TableRow fcb = new TableRow("FC Basel 1983", 63, 55);
        TableRow gc = new TableRow("Grasshopper Club Zürich", 50, 54);
        TableRow fcsg = new TableRow("FC St. Gallen 1879", 50, 54);
        TableRow fcl = new TableRow("FC Luzern", 64, 55);

        Table superLeague2021To2022 = new Table();
        superLeague2021To2022.AddRow(fcb);
        superLeague2021To2022.AddRow(gc);
        superLeague2021To2022.AddRow(fcsg);
        superLeague2021To2022.AddRow(fcl);

        Console.WriteLine(superLeague2021To2022);
    }
}