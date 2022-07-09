namespace StringFormatting;

public class TableRow
{
    public string Team { get; set; }
    public int Goals { get; set; }
    public int Points { get; set; }

    public TableRow(string team, int goals, int points)
    {
        Team = team;
        Goals = goals;
        Points = points;
    }
}