using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Sechdiyim_Kartlar;

public class KartSechManage : MonoBehaviour
{
    public GameObject _kartlarim,VerilenKartlar,uimanager;
    public Sechdiyim_Kartlar myKard;
    public _UIManager UIManager;
    Transform kart;



    public void baxGor(GameObject gameObject)
    {
        switch (gameObject.GetComponent<_CardUI>().card.Name)
        {
            case "oğru dünyasından sözler":
                
                break;
            case "sen biliren kimem?":
             //   Debug.Log("sen biliren kimem?");
                break;


        }
           

    }
    public void deyish(GameObject gameObject)
    {
        if (gameObject.transform.parent == VerilenKartlar.transform&&_kartlarim.transform.childCount<=4)
        {
            gameObject.transform.SetParent(_kartlarim.transform);
        }
        else
        {
            gameObject.transform.SetParent(VerilenKartlar.transform);
        }
        
    }

    public void gonder()
    {
        

        for (int i = 0; i < 5; i++)
        {
            //Debug.Log("saslam");
            kart = _kartlarim.transform.GetChild(i);
            
            kartlarim.menimKartlar.Add(kart.GetComponent<_CardUI>().card);
            //Debug.Log(kartlarim.menimKartlar[i].Name);
        }
        
        
        
        
    }



}
