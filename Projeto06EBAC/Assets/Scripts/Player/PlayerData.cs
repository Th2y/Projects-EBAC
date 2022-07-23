using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Player")]
public class PlayerData : ScriptableObject
{
    [Header("Colors")]
    public Color startColor;
    public Color aliveColor;
    public Color dieColor;
}
