using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
    public CardData Data {  get;private set; }
    public int Cost {  get; set; }
    public int Damage {  get; set; }
    public Card(CardData data)
    {
        Data = data;

        Cost = data.cost;
        Damage = data.damage;
    }
}