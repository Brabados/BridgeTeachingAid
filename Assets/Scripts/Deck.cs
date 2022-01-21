using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public List<Card> AvalibleCards;

    private Dictionary<int, Texture> CardDictionary;

    [System.Serializable]
    public struct CardPrefabs
    {
        public int Val;
        public Texture Prefab;
    }

    public CardPrefabs[] _CardPrefabs;

    public void Awake()
    {
         CardDictionary = new Dictionary<int, Texture>();

        for (int i = 0; i< _CardPrefabs.Length; i++)
        {
            if (!CardDictionary.ContainsKey(_CardPrefabs[i].Val))
            {
                CardDictionary.Add(_CardPrefabs[i].Val, _CardPrefabs[i].Prefab);
            }
        }

        foreach(CardPrefabs x in _CardPrefabs)
        {
            GameObject obj = new GameObject(x.Val.ToString());
            Card Placeholder = obj.AddComponent<Card>();
            Placeholder.Initalize(x.Val, x.Prefab);
            AvalibleCards.Add(Placeholder);
        }
    }

    public Card DealCard()
    {
        Card ToReturn;
        try
        {
            ToReturn = AvalibleCards[Random.Range(0, AvalibleCards.Count)];        
            AvalibleCards.Remove(ToReturn);
        }
        catch
        {
            ToReturn = null;
            Debug.LogError("No cards remain or Number of cards outside of range");
        }

        return ToReturn;

    }

}
