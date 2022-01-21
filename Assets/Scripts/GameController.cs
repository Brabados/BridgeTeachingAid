using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Hand South;
    public Hand North;
    public Hand East;
    public Hand West;
    public Deck TheDeck;

    public void Start()
    {
        SetUp(South);
        SetUp(North);
        SetUp(East);
        SetUp(West);
    }

    public void SetUp(Hand x)
    {
        for (int i = 0; i < 13; i++)
        {
            x.Draw(TheDeck.DealCard());
        }
    }

    public void ShowHand(Card X)
    {

    }
}
