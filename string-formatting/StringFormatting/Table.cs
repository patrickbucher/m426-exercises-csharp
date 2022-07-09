namespace StringFormatting;

public class Table
{
    private List<TableRow> rows = new List<TableRow>();

    public void AddRow(TableRow row)
    {
        rows.Add(row);
    }

    public override string ToString()
    {
        StringWriter output = new();
        output.WriteLine("{0,-30} {1,5} {2,6}", "Team", "Goals", "Points");
        output.WriteLine("----------------------------------------------");
        foreach (TableRow row in rows)
        {
            output.WriteLine($"{row.Team,-30} {row.Goals,5} {row.Points,6}");
        }
        return output.ToString();
    }
}