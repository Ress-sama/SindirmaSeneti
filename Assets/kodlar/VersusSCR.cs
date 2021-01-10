using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VersusSCR : MonoBehaviour
{
    private float timer=5;
    bool dayan=false;
    public Animator animator;

    void FixedUpdate()
    {
        timer -= Time.deltaTime;

        if (timer<0&&!dayan)
        {
            StartCoroutine("dayan2san");
            
            
        }
    }

    IEnumerator dayan2san()
    {
        dayan = true;
        Debug.Log("Dayandim");
        animator.SetBool("Start", true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Oyun");
        
    }
}
