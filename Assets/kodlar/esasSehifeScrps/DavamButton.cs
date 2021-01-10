using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DavamButton : MonoBehaviour
{
    public KartSechManage kartSecMan;
    public Animator animator;
    
    public void basdim()
    {
        Debug.Log("Burdayam");
        kartSecMan.gonder();
        animator.SetBool("Start", true);
        StartCoroutine("dayan");
        
    }

    IEnumerator dayan()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(3);
    }
}
