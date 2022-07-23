using UnityEngine;

public class CharactersData : ScriptableObject
{
    [Header("Life")]
    public float life = 100f;
    public float damage = 10f;

    [Header("Colors")]
    public Color initialColor;
    public Color damageColor;
}
