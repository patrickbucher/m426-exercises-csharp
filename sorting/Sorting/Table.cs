namespace StringFormatting;

public class Table
{
    private List<TableRow> rows = new List<TableRow>();

    public void AddRow(TableRow row)
    {
        rows.Add(row);
    }

    public void Sort()
    {
        rows.Sort((x, y) =>
        {
            if (x.Points > y.Points)
            {
                return -1;
            }
            else if (x.Points < y.Points)
            {
                return 1;
            }
            else if (x.Goals > y.Goals)
            {
                return -1;
            }
            else if (x.Goals < y.Goals)
            {
                return 1;
            }
            else
            {
                return x.Team.CompareTo(y.Team);
            }
        });
    }

    public override string ToString()
    {
        Sort();
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