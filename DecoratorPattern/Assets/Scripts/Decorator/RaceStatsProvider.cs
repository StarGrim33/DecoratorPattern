public class RaceStatsProvider : IStatProvider
{
    private readonly IStatProvider _statProvider;
    private readonly Unit _unit;

    public RaceStatsProvider(IStatProvider statProvider, Unit unit)
    {
        _statProvider = statProvider;
        _unit = unit;
    }

    public int GetAgility()
    {
        int multiplier = 3;
        int baseAgility = _statProvider.GetAgility();

        if (_unit.RaceType == RaceType.Elf)
            return baseAgility * multiplier;
        else
            return baseAgility;
    }

    public int GetIntelligence()
    {
        int multiplier = 2;
        int baseIntelligence = _statProvider.GetIntelligence();

        if (_unit.RaceType == RaceType.Human)
            return baseIntelligence * multiplier;
        else
            return baseIntelligence;
    }

    public int GetStrength()
    {
        int multiplier = 2;
        int baseStrength = _statProvider.GetStrength();

        if (_unit.RaceType == RaceType.Human)
            return baseStrength * multiplier;
        else
            return baseStrength;
    }
}
