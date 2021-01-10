using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct Card
{
    public string Ad;
    public int Zerer,Defence,Dux,Risk,Id;
    


    public Card(string ad, int zerer, int defence, int dux, int risk,int id)
    {
        Ad = ad;
        Zerer = zerer;
        Defence = defence;
        Dux = dux;
        Risk = risk;
        Id = id;
        
    }


}

public static class CardManager
{
    public static List<Card> allCards = new List<Card>();
    public static List<Card> mKartlar = new List<Card>();
    public static List<Card> dKartlar = new List<Card>();
}
public class CardManagerScr : MonoBehaviour
{

   
    public void Awake()
    {

        
    
        CardManager.allCards.Add(new Card("sen biliren kimem?", 10, 0, 1,0,1));
        CardManager.allCards.Add(new Card("oğru dünyasından sözler", 25, 0, 3,0,2));
        CardManager.allCards.Add(new Card("rusca sözler", 20, 0, 2,0,3));
        CardManager.allCards.Add(new Card("söyüş söy", 30, 0, 4,3,4));
        CardManager.allCards.Add(new Card("borzulanmaq-şişmisən ala?", 15, 0, 2,9,5));
        CardManager.allCards.Add(new Card("xaxa?", 15, 0, 2,9,6));
        CardManager.allCards.Add(new Card("xd-da adala?", 15, 0, 2,9,7));
        CardManager.allCards.Add(new Card("sdsd-dad alaaa?", 15, 0, 2,9,8));

        //menim kartlar
        CardManager.mKartlar.Add(CardManager.allCards[0]);
        CardManager.mKartlar.Add(CardManager.allCards[1]);
        CardManager.mKartlar.Add(CardManager.allCards[2]);
        CardManager.mKartlar.Add(CardManager.allCards[3]);
        CardManager.mKartlar.Add(CardManager.allCards[4]);
        //dusmen kartlar





    }
}
