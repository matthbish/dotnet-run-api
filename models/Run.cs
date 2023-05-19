namespace RunApi;

public class Run
{
    public long Id { get; set; }

    public DateOnly Date { get; set; }

    public double Distance { get; set; }

    public string? Notes { get; set; }
}
