public class CharacterStats : IStatProvider
{
    private int _strength = 6;

    private int _intelligence = 2;

    private int _agility = 3;

    public int GetAgility()
    {
        return _agility;
    }

    public int GetIntelligence()
    {
        return _intelligence;
    }

    public int GetStrength()
    {
        return _strength;
    }
}
