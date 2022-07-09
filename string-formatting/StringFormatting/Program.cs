namespace StringFormatting;

public class Program
{
    public static void Main(string[] args)
    {
        TableRow fcl = new TableRow("FC Luzern", 37, 9);
        TableRow fcb = new TableRow("FC Basel 1983", 52, 43);
        TableRow gc = new TableRow("Grasshopper Club Zürich", 45, 30);

        Table superLeague2021To2022 = new Table();
        superLeague2021To2022.AddRow(fcl);
        superLeague2021To2022.AddRow(fcb);
        superLeague2021To2022.AddRow(gc);

        Console.WriteLine(superLeague2021To2022);
    }
}