using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
public class TEST2 : MonoBehaviour
{


    public GameObject dKartYeri;
    Transform kid;
    private int n = 5;
    public GameObject mkartYeri,doyushBtn,dysBtnIsiq,dLight2,dLight;
    public _UIManager oyunManager;
    _CardUI cardUI;

    //DropKartScr drp;
    public int say, dsay;

    public void deyish()
    {
        StartCoroutine("dayanSuka");
        Debug.Log("burdayam suka10000");


        dsay = 5;
        say = mkartYeri.transform.childCount;
        if (oyunManager.qoy == true)
        {
            Debug.Log("burdayam suka666");

            bool t = true;
            for (int i = 0; i < n && t; i++)
            {
                Debug.Log("burdayam suka555");
                kid = transform.GetChild(i);
                if (kid.transform.GetComponent<_CardUI>().card.cardClass == CardClass.attack)
                {
                    kid.transform.localRotation = Quaternion.identity;
                    kid.SetParent(dKartYeri.transform);
                    n--;
                    t = false;
                    doyushBtn.SetActive(true);
                    dysBtnIsiq.SetActive(true);
                    
                }
                Debug.Log("t nin hali" + t);
            }
                if (t)
                {
                    Debug.Log("Bura Girdim aq");
                    kid = transform.GetChild(Random.Range(0, n));
                    kid.transform.localRotation = Quaternion.identity;
                    doyushBtn.SetActive(true);

                    kid.SetParent(dKartYeri.transform);
                    dysBtnIsiq.SetActive(true);

                    n--;


                }
            


        }
        else if (say >= 1 && dKartYeri.transform.childCount < 1)
        {
            Debug.Log("burdayam suka1");
            bool y = true ;
            for (int i = 0; i <n&&y; i++)
            {
                Debug.Log("burdayam suka2");
                kid = transform.GetChild(i);
                if (kid.transform.GetComponent<_CardUI>().card.cardClass == CardClass.bonus)
                {
                    Debug.Log("burdayam suka3");
                    kid.transform.localRotation = Quaternion.identity;
                    kid.SetParent(dKartYeri.transform);
                    n--;
                    y = false;
                    doyushBtn.SetActive(true);
                    dysBtnIsiq.SetActive(true);
                }
            }
                if (y)
                    {
                    Debug.Log("burdayam suka4");
                    kid = transform.GetChild(Random.Range(0, n));
                    kid.transform.localRotation = Quaternion.identity;

                    kid.SetParent(dKartYeri.transform);

                    n--;
                    doyushBtn.SetActive(true);
                dysBtnIsiq.SetActive(true);
            }
            
        }
    
    
    
    
    }

    IEnumerator dayanSuka()
    {
        yield return new WaitForSeconds(0.2f);

        for (int i = 0; i < 9; i++)
        {
            dLight2.GetComponent<Light2D>().intensity += 0.1f;
            dKartYeri.GetComponent<CanvasGroup>().alpha += 0.1f;
            yield return new WaitForSeconds(0.02f);
        }





    }



}


