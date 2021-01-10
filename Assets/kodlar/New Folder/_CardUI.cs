using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class _CardUI : MonoBehaviour
{
    public scrpableObj card;

    public Text textName;


    public Text textZerer;
    public Text textDux;
    public Text textRisk;
    public Text textDefence;
    



    public void Start()
    {
        if (card.cardClass == CardClass.attack)
        {
            attackDisplayCard();
        }
        else
        {
            DefanceDisplayCard();
        }
    }

    private void attackDisplayCard()
    {
        textName.text = card.Name;
        textZerer.text = card.Zerer.ToString();
        textDux.text = card.Dux.ToString();
        textRisk.text = card.Risk.ToString();


    }private void DefanceDisplayCard()
    {
        textName.text = card.Name;
        textDux.text = card.Dux.ToString();
        textDefence.text = card.Defence.ToString();


    }
   
}
