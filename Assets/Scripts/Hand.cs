using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public List<Card> CardsInHand;
    public GameObject Prefab;

    public void Start()
    {
        
    }

    public void Draw(Card ToAdd)
    {
        MeshRenderer Placeholder = ToAdd.gameObject.AddComponent<MeshRenderer>();
        Placeholder.material = Prefab.GetComponent<MeshRenderer>().material;
        Placeholder.material.SetTexture("_MainTex", ToAdd.Face);
        ToAdd.gameObject.AddComponent<MeshFilter>().mesh = Prefab.GetComponent<MeshFilter>().mesh;
        ToAdd.transform.rotation = Prefab.transform.rotation;
        ToAdd.transform.localScale = Prefab.transform.localScale;
        ToAdd.gameObject.transform.position = this.transform.position;
        ToAdd.gameObject.transform.parent = this.transform;
        CardsInHand.Add(ToAdd);
    }
}
