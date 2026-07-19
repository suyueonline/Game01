using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CardView : MonoBehaviour
{
    [SerializeField]
    private TMP_Text costText;
    [SerializeField]
    private TMP_Text nameText;
    [SerializeField]
    private TMP_Text descriptionText;
    private Card card;
    public void Setup(Card card)
    {
        this.card = card;
       if(card == null)
        {
            Debug.LogError("Card is null!");
        }

        costText.text = card.Cost.ToString();
        nameText.text = card.Data.cardName;
        descriptionText.text = card.Data.description;
    }
}
