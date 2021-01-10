using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class araSehne2Man : MonoBehaviour
{

    public float timer, msuret = 2.5f, adamSuret = 1f;
    public GameObject mashin,oyuncu;
    public Animator animator;
    public bool dayan=false,f = true, t = true, y=true;
    private void FixedUpdate()
    {
        timer -= Time.deltaTime;
        
        if(timer < 10&&dayan==false)
        {
            oyuncu.transform.position=new Vector3(oyuncu.transform.position.x+ adamSuret * Time.deltaTime, oyuncu.transform.position.y, oyuncu.transform.position.z);
            if (oyuncu.transform.position.x> 7.85f)
            {
                dayan = true;
            }
        }
        if (timer <5 &&f)
        {
            oyuncu.gameObject.SetActive(false);
            f = false;
        }

        if (timer < 4)
        {
            msuret = msuret + 0.2f;
            mashin.transform.position = new Vector3(mashin.transform.position.x + msuret * Time.deltaTime, mashin.transform.position.y, mashin.transform.position.z);

        }
        if (timer < 2&&t)
        {
            animator.SetBool("Start", true);
            StartCoroutine("dayann");
            Debug.Log("gediremaa");
            t = false;
        }
        

    }
    IEnumerator dayann()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Versus");
    }
}
