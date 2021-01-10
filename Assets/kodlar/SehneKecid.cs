using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SehneKecid : MonoBehaviour
{

    public Animator animator;


    private void Start()
    {
        animator.SetTrigger("bashla");
    }

    public void LoadScene() 
    {
        Debug.Log("Burdayam1");
        StartCoroutine(LoadLLevel(1));
        Debug.Log("Burdayam2");

    }
    
    IEnumerator LoadLLevel(int i)
    {
        Debug.Log("Burdayam3");
        animator.SetBool("Start",true);
        Debug.Log("Burdayam4");
        yield return new WaitForSeconds(3);
        Debug.Log("Burdayam5");
        SceneManager.LoadScene(i);

    }

}
