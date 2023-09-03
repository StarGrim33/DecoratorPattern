using UnityEngine;

public class Player : MonoBehaviour
{
    private IStatProvider _statProvider;

    public void Init(IStatProvider statProvider)
    {
        _statProvider = statProvider;
    }

    public void ShowStats()
    {
        Debug.Log($"Strength is { _statProvider.GetStrength()}");
        Debug.Log($"Agility is {_statProvider.GetAgility()}");
        Debug.Log($"Intelligence is {_statProvider.GetIntelligence()}");
    }
}
