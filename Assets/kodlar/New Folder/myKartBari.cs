using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myKartBari : MonoBehaviour
{
    public GameObject KartBarim;
    public GameObject attack, deffence;
    private GameObject _attack,_Defence;
    //Sechdiyim_Kartlar menimOlanKartlar;

    private void Start()
    {
        ///codeInstantiatedPrefab = Instantiate(Resources.Load("Prefabs/ScriptableObjectDEFENCE", typeof(GameObject))) as GameObject;
       // attack = (GameObject)Resources.Load("Prefabs/ScriptableObject", typeof(GameObject));
    }
    public void KartimiDuz(CardClass tip,scrpableObj _card)
    {
        

        if (tip == CardClass.attack)
        {

            _attack = Instantiate(attack,KartBarim.transform);
            _attack.GetComponent<_CardUI>().card = _card;
        }
        else
        {
            _Defence = Instantiate(deffence, KartBarim.transform);
            _Defence.GetComponent<_CardUI>().card = _card;
        }
      
    }
}
