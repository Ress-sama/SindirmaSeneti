using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Experimental.Rendering.Universal;


public class playerKOD : MonoBehaviour
{
    public Animator salla;
    //canlar
    public int dcan=25;
    public int mcan=25;
    public int sonCan;

    //menim zerer ve defansim
    public int mzerer = 0;
    public int mdefence = 0;
    public int MenimRisk;
    //dusmenin zerer ve defansi
    public int defence = 0;
    public int dzerer = 0;
    public int DusmenRisk;
    public TEST2 test2blin;
     public Animator animator;
    public static class ozellikler
    {
        public static int sindirmaQ;
        public static int qorumaQ;
        public static int elaveCan;
    }
    


    public int dux;
    public TextMeshProUGUI _zerer;
    
    
    public GameObject mCanText, dCanText,mkartYeri,dusmenYeri,MenimYer,mLight,dLight;
    public dKartYeri dkartYeri;
    public TEST mKartYeri;
    public _UIManager mana;
    public GameObject sindin, sindirdin,doyush,kecid, dysBtnIsiq;

    private void Awake()
    {
        mcan = 25;
        dcan = 25;
        MenimYer.SetActive(false);
        mLight.SetActive(false);
    }

    void Start()
    {
        sonCan=mcan+ ozellikler.elaveCan;
        mCanText.GetComponent<Text>().text = sonCan.ToString();
        dCanText.GetComponent<Text>().text = dcan.ToString();
        
    }

    public void myRiskAl(int mRisk)
    {
        MenimRisk = mRisk;
    }
    public void DRiskAl(int dRisk)
    {
        DusmenRisk = dRisk;
    }


    public void uron(int uron)
    {
        mzerer = uron;
    }
    public void duron(int uron)
    {
        dzerer = uron;
    }
    public void defenceAL(int Defence)
    {
        defence = Defence;
    }
    public void mdefenceAL(int Defence)
    {
        mdefence = Defence;
    }


    private void KartEtrafiIsqSon()
    {
        MenimYer.SetActive(false);
        mLight.SetActive(false);
        test2blin.dKartYeri.GetComponent<CanvasGroup>().alpha = 0;
        test2blin.dLight2.GetComponent<Light2D>().intensity = 0;

       
    }


    

    public void mCanApar()
    {
        int sonZerer2;
        float sonRisk2;
        sonRisk2 = (100 - DusmenRisk);
        if(sonRisk2!=0)
        sonRisk2 = sonRisk2 / 100;
        Debug.Log("Dusmen sonrisk" + sonRisk2);




        if (Random.value > sonRisk2)
        {
            Debug.Log("DUSMEN OLDU AMK");
            sonZerer2 = mzerer / 2;
            dcan = dcan - sonZerer2;
            dCanText.GetComponent<Text>().text = dcan.ToString();
            dkartYeri.sil();
            mKartYeri.sil();
            mana.mana();
            doyush.SetActive(false);
            KartEtrafiIsqSon();
            salla.SetTrigger("salla");
            if (sonCan <= 0)
            {
                sindin.SetActive(true);
                Time.timeScale = 0;
            }
            else if (dcan < 0)
            {
                sindirdin.SetActive(true);
                Time.timeScale = 0;
            }


        }
        else
        {
            int sonZerer;
            int ilkZerer;
            ilkZerer = dzerer - ((dzerer * mdefence) / 100);
            sonZerer = ilkZerer - ((ilkZerer * ozellikler.qorumaQ) / 100);
           // Debug.Log("Menim son zerer = " + sonZerer);
            sonCan = sonCan - sonZerer;
            //Debug.Log("menim Can" + sonCan);
            mCanText.GetComponent<Text>().text = sonCan.ToString();
            dkartYeri.sil();
            mKartYeri.sil();
            mana.mana();
            doyush.SetActive(false);
            KartEtrafiIsqSon();
            salla.SetTrigger("salla");
            if (sonCan <= 0)
            {
                sindin.SetActive(true);
                Time.timeScale = 0;
            }
            else if (dcan < 0)
            {
                sindirdin.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }



    public void restar()
    {
        Destroy(kecid);
        SceneManager.LoadScene("Oyun");
        sonCan = mcan + ozellikler.elaveCan;
        
    }
    public void evvel()
    {

        SceneManager.LoadScene("esasSehife");
    }

    public void canApar()
    {
        int sonZerer2;
        float sonRisk;
        sonRisk = (100 - MenimRisk);
        sonRisk = sonRisk / 100;
        //Debug.Log("sonrisk"+sonRisk);

        if (Random.value > sonRisk)
        {
            Debug.Log("OLDUN AMK");

            sonZerer2 = mzerer / 2;
            sonCan = sonCan - sonZerer2;
            mCanText.GetComponent<Text>().text = sonCan.ToString();
            dkartYeri.sil();
            mKartYeri.sil();
            mana.mana();
            mana.waitAndKartQoy();
            dysBtnIsiq.SetActive(false);
            KartEtrafiIsqSon();
            salla.SetTrigger("salla");
            if (dcan <= 0)
            {
                sindirdin.SetActive(true);
                Time.timeScale = 0;
            }
            else if (sonCan < 0)
            {
                sindin.SetActive(true);
                Time.timeScale = 0;
            }


        }
        else
        {
            int ilkZerer;
            int sonZerer;
            ilkZerer = mzerer - ((mzerer * defence) / 100);
            sonZerer = ilkZerer + ((ilkZerer * ozellikler.sindirmaQ) / 100);
            dcan = dcan - sonZerer;
            dCanText.GetComponent<Text>().text = dcan.ToString();
            dkartYeri.sil();
            mKartYeri.sil();
            mana.mana();
                dysBtnIsiq.SetActive(false);
            mana.waitAndKartQoy();
            KartEtrafiIsqSon();
            salla.SetTrigger("salla");
            if (dcan < 0)
            {
                sindirdin.SetActive(true);
                Time.timeScale = 0;
            }
            else if (sonCan <= 0)
            {
                sindin.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }

}
