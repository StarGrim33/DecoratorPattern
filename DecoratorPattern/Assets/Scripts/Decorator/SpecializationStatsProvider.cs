public class SpecializationStatsProvider : IStatProvider
{
    private readonly IStatProvider _statProvider;
    private readonly Specialization _specialization;

    public SpecializationStatsProvider(IStatProvider statProvider, Specialization specialization)
    {
        _statProvider = statProvider;
        _specialization = specialization;
    }

    public int GetAgility()
    {
        int multiplier = 3;
        int baseAgility = _statProvider.GetAgility();

        if (_specialization.SpecializationType == SpecializationType.Thief)
            return baseAgility * multiplier;
        else
            return baseAgility;
    }

    public int GetIntelligence()
    {
        int multiplier = 2;
        int baseIntelligence = _statProvider.GetIntelligence();

        if (_specialization.SpecializationType == SpecializationType.Wizard)
            return baseIntelligence * multiplier;
        else
            return baseIntelligence;
    }

    public int GetStrength()
    {
        int multiplier = 2;
        int baseStrength = _statProvider.GetStrength();

        if (_specialization.SpecializationType == SpecializationType.Warrior)
            return baseStrength * multiplier;
        else
            return baseStrength;
    }
}
