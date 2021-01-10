using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardClass
{
    attack,
    bonus
}

[CreateAssetMenu(fileName ="new Card", menuName = "Card")]
public class scrpableObj : ScriptableObject
{

    public string Name;


    public int Zerer;
    public int Dux;
    public int Risk;
    public int Defence;


    public CardClass cardClass;


}
