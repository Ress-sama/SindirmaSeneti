using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Sechdiyim_Kartlar;

public class _UIManager : MonoBehaviour
{
    GameObject kart;
    public Sechdiyim_Kartlar _kartlar;
    public GameObject duxx;
    public GameObject myKart, Dkart,mKartBari;
    public bool siraMende;
    public int yeniMana ,dux;
    public TEST2 dusmenKartQoyma;
    public bool qoy;
    public GameObject heri;
    public myKartBari karttttt;
    public bool heriChekActive;
    //private int a = 0;
    public GameObject bashla,dysBtnIsiq,mLight, dLight;
    public playerKOD oyuncu;
    public DropKartScr dropKartScr;
    public bool kartVar;

    private void Awake()
    {
        setcard();
        
    }
    private void Start()
    {
        kartVar = false;
        siraMende = true;
        qoy = false;
        heriChekActive = true;
        


        for (int i = 0; i < 5; i++)
        {
            Debug.Log(kartlarim.menimKartlar[i].Name);
        }



    }

    private void Update()
    {
        
    }


    public void mana()
    {
        yeniMana = dux + 2;
        if (yeniMana >= 10)
        {
            yeniMana = 10;
            dux = yeniMana;
        }
        else 
        {
            dux = yeniMana;
        }
        
        duxx.GetComponent<Text>().text = dux.ToString();

    }
    private void ele()
    {
        //Debug.Log(siraMende);
        if (siraMende == false)
        {
           // Debug.Log("burdayam suka3");
            qoy = true;
            dusmenKartQoyma.deyish();
            heri.SetActive(false);
            bashla.SetActive(true);
            dysBtnIsiq.SetActive(true);
            qoy = false;
            
        }
        
    }
    public void dusmenRiskYolla()
    {
        oyuncu.DRiskAl(myKart.transform.GetChild(0).GetComponent<_CardUI>().card.Risk);
    }

    public void mDefenceAl()
    {
       oyuncu.mdefenceAL( myKart.transform.GetChild(0).GetComponent<_CardUI>().card.Defence);
    }
    public void dusmenDamageAl()
    {
        int a;
        a = Dkart.transform.GetChild(0).GetComponent<_CardUI>().card.Zerer;
        Debug.Log(a);
        oyuncu.duron(a);
    }

    public void yoxlakart()
    {
        StartCoroutine("dayan2San");
    }

    public void waitAndKartQoy()
    {
        StartCoroutine("dayan3San");
        //Debug.Log("burdayam suka1");
    }

    IEnumerator dayan2San()
    {
        yield return new WaitForSeconds(0.2f);
        yoxlaMana();
    }
    IEnumerator dayan3San()
    {
        
        yield return new WaitForSeconds(3);
        ele();
       // Debug.Log("burdayam suka2");

    }

    public void yoxlaMana()
    {
        if (dux < myKart.transform.GetChild(0).GetComponent<_CardUI>().card.Dux)
        {
            myKart.transform.GetChild(0).SetParent(mKartBari.transform);
            kartVar = false;

        }
        else
        {
            kartVar = true;
        }
    }

   /* public void kartnalla(CardClass tip, scrpableObj _card)
    {
        if (tip == CardClass.attack)
        {
            kart = Instantiate(attack, new Vector3(0, 0, 0), Quaternion.identity, this.gameObject.transform);
            kart.GetComponent<_CardUI>().card = _card;
        }
        else
        {
            kart = Instantiate(deffence, new Vector3(0, 0, 0), Quaternion.identity, this.gameObject.transform);
            kart.GetComponent<_CardUI>().card = _card;
        }
    }*/

    public void setcard()
    {
        for (int i = 0; i < 5; i++)
        {
            
           karttttt.KartimiDuz(kartlarim.menimKartlar[i].cardClass, kartlarim.menimKartlar[i]);
        }


    }





}
 
