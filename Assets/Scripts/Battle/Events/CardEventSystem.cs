using System;

public static class CardEventSystem
{
    public static event Action<Card> CardDrawn;


    public static void RaiseCardDrawn(Card card)
    {
        CardDrawn?.Invoke(card);
    }
}