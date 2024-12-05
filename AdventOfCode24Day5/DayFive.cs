public class DayFive
{
    private readonly string[] _rules;
    private readonly string[] _manuals;

    public DayFive(string[] rules, string[] manuals)
    {
        _rules = rules;
        _manuals = manuals;
    }
    public DayFive(string rules, string manuals)
    {
        _rules = rules.Split("\n");
        _manuals = manuals.Split("\n");
    }

    public (List<string>, int) PartOne()
    {
        List<string> correctManuals = new List<string>();
        int sum = 0;

        // TODO

        return (correctManuals, sum);
    }

    
}