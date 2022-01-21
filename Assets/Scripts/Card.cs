using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{

    private int _Value;
    private Texture _Face;

    public int Value
    {
        get { return _Value; }
    }

    public Texture Face
    {
        get { return _Face; }
    }

    public void Initalize(int value, Texture face)
    {
        _Value = value;
        _Face = face;
    }

}
