
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DefenceCardUI : MonoBehaviour
{
    
    public scrpableObj card;

    public TextMeshProUGUI textName;


    public Text textDefence;
    public Text textDux;


    public Text textDefenceKartClass;


    public void Start()
    {
        defenceDisplayCard();
    }

    private void defenceDisplayCard()
    {
        textName.text = card.Name;
        textDux.text = card.Dux.ToString();
        textDefence.text = card.Defence.ToString();

    }
}
