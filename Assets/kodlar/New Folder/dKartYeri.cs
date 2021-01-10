using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dKartYeri : MonoBehaviour
{
    public int defence;
    public playerKOD player;
    public void defenceYolla()
    {
        defence = this.transform.GetChild(0).GetComponent<_CardUI>().card.Defence;

        if (this.transform.GetChild(0).GetComponent<_CardUI>().card.cardClass != CardClass.bonus)
        {
            player.defenceAL(0);
        }
        else
        {
            player.defenceAL(defence);
            Debug.Log("Dusmen son defence" + defence);
        }


    }
    public void sil()
    {
        Destroy(transform.GetChild(0).gameObject);

    }
   
}
