using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public enum FieldType
{
    OZ_PANELIM,
    DUSMEN_PANELI,
    OZ_KART_YERIM,
    DUSMEN_KART_YERI
}
public class DropKartScr : MonoBehaviour, IDropHandler
{

    public _CardManager cardManager;
    public _UIManager OyunManager;
    
    public GameObject bashla,myKart,mKartBari;

    public FieldType type;
    public int say;
    public void OnDrop(PointerEventData eventData)
    {
        

        draggable card = eventData.pointerDrag.GetComponent<draggable>();
        if (card) 
        {

            if (SceneManager.GetActiveScene().name == "KartSech")
            {
                card.DefaultParent = transform;
            }


            else if (SceneManager.GetActiveScene().name == "Oyun")
            {
                if (type == FieldType.OZ_KART_YERIM && OyunManager.kartVar == false)
                {

                    card.DefaultParent = transform;
                    OyunManager.yoxlakart();
                }
            }

                


            


        }





    }

   
}
