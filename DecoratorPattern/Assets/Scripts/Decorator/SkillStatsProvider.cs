public class SkillStatsProvider : IStatProvider
{
    private readonly IStatProvider _statProvider;
    private readonly  Skill _skill;

    public SkillStatsProvider(IStatProvider statProvider, Skill skill)
    {
        _statProvider = statProvider;
        _skill = skill;
    }

    public int GetAgility()
    {
        int multiplier = 3;
        int baseAgility = _statProvider.GetAgility();

        if (_skill.Type == SkillType.ShadowDance)
            return baseAgility * multiplier;
        else
            return baseAgility;
    }

    public int GetIntelligence()
    {
        int multiplier = 2;
        int baseIntelligence = _statProvider.GetIntelligence();

        if (_skill.Type == SkillType.Fireball)
            return baseIntelligence * multiplier;
        else
            return baseIntelligence;
    }

    public int GetStrength()
    {
        int multiplier = 2;
        int baseStrength = _statProvider.GetStrength();

        if (_skill.Type == SkillType.Rage)
            return baseStrength * multiplier;
        else
            return baseStrength;
    }
}
