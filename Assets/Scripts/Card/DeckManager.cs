using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckManager : MonoBehaviour
{
    [SerializeField]
    private List<CardData> startingDeck = new();

    private List<Card> drawPile = new();//牌库
    private List<Card> hand = new();//玩家手牌
    private List<Card> discardPile = new();//弃牌堆


    private void Start()
    {
        foreach (var cardData in startingDeck)
        {
            drawPile.Add(new Card(cardData));
        }

        Debug.Log($"牌库初始化完成，共{drawPile.Count}张牌");

        for(int i = 0; i < 5; i++)
        {
            DrawCard();
        }
    }

    public void DrawCard()
    {
        if (drawPile.Count == 0)
        {
            Debug.Log("牌库为空！");
            return;
        }

        Card card = drawPile[0];
        drawPile.RemoveAt(0);

        hand.Add(card);

        Debug.Log($"抽到卡牌：{card.Data.cardName}");
    }
}