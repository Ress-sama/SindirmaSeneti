using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TEST : MonoBehaviour
{

    public _CardUI _Card;
    public int zerer;
    public int risk;
    public playerKOD player;
    
    public void zererYolla()
    {       
         zerer = this.transform.GetChild(0).GetComponent<_CardUI>().card.Zerer;
         player.uron(zerer);        

    }
    public void myRiskYolla()
    {
        risk= this.transform.GetChild(0).GetComponent<_CardUI>().card.Risk;
        player.myRiskAl(risk);

    }



    public void sil()
    {
        Destroy(transform.GetChild(0).gameObject);
    }




}
