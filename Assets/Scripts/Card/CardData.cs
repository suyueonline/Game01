using UnityEngine;
[CreateAssetMenu(fileName = "New Card", menuName = "Card/New Card")]
public class CardData : ScriptableObject
{
    [Header("基础信息")]
    public string cardName;

    [TextArea]
    public string description;

    [Header("数值")]
    public int cost;

    public int damage;
}