using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandManager : MonoBehaviour
{
    [SerializeField]
    private CardView cardViewPrefab;

    [SerializeField]
    private Transform handArea;

    private List<Card> handCards = new();


    private void OnEnable()
    {
        CardEventSystem.CardDrawn += ShowCard;
    }


    private void OnDisable()
    {
        CardEventSystem.CardDrawn -= ShowCard;
    }


    public void ShowCard(Card card)
    {
        handCards.Add(card);

        CardView newCardView = Instantiate(cardViewPrefab, handArea);

        newCardView.Setup(card);
    }
}