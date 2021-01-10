using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardInfoScr : MonoBehaviour
{
    public Card SelfCard;
    public TextMeshProUGUI Name;
    public TextMeshProUGUI zerer;
    public TextMeshProUGUI dux;
    public GameObject kart;
    //List<Card> cards = new List<Card>();

    public void showCardInfo(Card card)
    {
        SelfCard = card;
        Name.text = card.Ad;
        dux.text = card.Dux.ToString();
        zerer.text = card.Zerer.ToString();
    }



    private void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            showCardInfo(CardManager.allCards[i]);
            GameObject kartblin = Instantiate(kart, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
            kartblin.transform.parent = GameObject.Find("KartBari").transform;
            kartblin.transform.localScale = new Vector3(1, 1, 1);
            

        }


            
            


        
        
        



    }

}
