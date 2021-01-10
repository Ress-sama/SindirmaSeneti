using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyuncuCode : MonoBehaviour
{
    private bool chekAgiz,dayan=false;
    public float timer,msuret= 2.5f,adamSuret=1f;
    public GameObject masin,dostum,diplomat;
    public Animator animator;

    private void FixedUpdate()
    {
        timer -= Time.deltaTime;

        if (timer < 25&&dayan==false)
        {
            masin.GetComponent<Transform>().position = new Vector3(masin.transform.position.x - msuret * Time.deltaTime, masin.transform.position.y, masin.transform.position.z);
            if (masin.GetComponent<Transform>().position.x < 11)
            {
                dayan = true;
            }           
        }
        if (dayan&&timer<15)
        {
            dostum.SetActive(true);
            dostum.transform.position = new Vector3(dostum.transform.position.x - adamSuret * Time.deltaTime, dostum.transform.position.y, dostum.transform.position.z);

            if (dostum.transform.position.x< 3.42)
            {
                adamSuret = 0f;
            }

        }
        if (timer < 8)
        {
            diplomat.SetActive(true);
            if (timer < 5)
            {
                animator.SetBool("vaxtidi", true);
                if (timer < 1)
                {
                    animator.SetBool("yanSon", true);
                }

            }
        }

    }
}
