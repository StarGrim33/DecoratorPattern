using UnityEngine;

public class PlayerBootstrap : MonoBehaviour
{
    [SerializeField] private Player _player;

    private void Awake()
    {
        CharacterStats characterStats = new();
        Elf elf = new();
        ShadowDance shadowDance = new();
        Thief thief = new();

        IStatProvider decoratedStats = new RaceStatsProvider(
            new SkillStatsProvider(
                new SpecializationStatsProvider(characterStats, thief),
                shadowDance),
            elf);

        _player.Init(decoratedStats);
        _player.ShowStats();
    }
}
