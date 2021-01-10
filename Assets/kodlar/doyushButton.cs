using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
public class doyushButton : MonoBehaviour
{
    TEST test;
    playerKOD oyuncu;
    public TEST2 test2;
    dKartYeri DKartYeri;
    DropKartScr drp;
    _UIManager mana;
    private int say=0;
   public GameObject heri;
    public GameObject dusmenKartYeri, doyush,mIsiq,dIsiq,buttonIsiq; 
    private void Awake()
    {
       test = GameObject.FindGameObjectWithTag("KartYerim").GetComponent<TEST>();
       oyuncu = GameObject.FindGameObjectWithTag("Player").GetComponent<playerKOD>();
       //test2 = GameObject.FindGameObjectWithTag("DKartB").GetComponent<TEST2>();
       DKartYeri = GameObject.FindGameObjectWithTag("DKartYeri").GetComponent<dKartYeri>();
       drp = GameObject.FindGameObjectWithTag("KartYerim").GetComponent<DropKartScr>();
      mana = GameObject.FindGameObjectWithTag("_UIManager").GetComponent<_UIManager>();


    }
    public void Testiq()
    {        
        test2.deyish();
        

    }
    public void Doyush()
    {
        

        if (mana.siraMende == true)
        {

            heri.SetActive(false);
            test.zererYolla();
            test.myRiskYolla();
            DKartYeri.defenceYolla();
            oyuncu.canApar();
            mana.siraMende = !mana.siraMende;
            mana.kartVar = false;
            say++;
            if (say % 2 == 0)
            {
                heri.SetActive(true);
            }
            this.gameObject.SetActive(false);
            mIsiq.GetComponent<Light2D>().enabled = !mIsiq.GetComponent<Light2D>().enabled;
            dIsiq.GetComponent<Light2D>().enabled = !dIsiq.GetComponent<Light2D>().enabled;
        }

        else
        {
            
            mana.dusmenDamageAl();
            mana.mDefenceAl();
            mana.dusmenRiskYolla();
            oyuncu.mCanApar();
            mana.siraMende = !mana.siraMende;
            say++;
            mIsiq.GetComponent<Light2D>().enabled = !mIsiq.GetComponent<Light2D>().enabled;
            dIsiq.GetComponent<Light2D>().enabled = !dIsiq.GetComponent<Light2D>().enabled;
            buttonIsiq.SetActive(false);
            if (say % 2 == 0)
            {
                heri.SetActive(true);
                mana.kartVar = false;
                
            }

        }




    }

    


}
