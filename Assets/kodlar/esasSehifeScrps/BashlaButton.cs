using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class BashlaButton : MonoBehaviour
{
    public GameObject oyuncu, text, ozellik, panel1;
    public SehneKecid kecid;
    public playerKOD player;
    public int say;
    public bool stage1, stage2=false, stage3;
    public Bash_SManager bash_SManager;


    private void Start()
    {
        stage1 = true; 
    }
    public void init()
    {
        //Debug.Log(bash_SManager.maxArt);
        if (stage1 == true)
        {
            oyuncu.transform.position = new Vector2(-6, 0);
            text.GetComponent<TextMeshProUGUI>().text = ("Başlanğıc özəlliklərini\n seç");
            ozellik.SetActive(true);
            stage1 = false;
        }
        else if (bash_SManager.maxArt == 0)
        {
            bash_SManager.falanFilan();
           // oyuncu.SetActive(false);
           // ozellik.SetActive(false);
            //panel1.SetActive(false);
            kecid.LoadScene();
            

        }





    }
 //   public void SehneDeyish() => SceneManager.LoadScene("Oyun");**

    public void artirS()
    {
        bash_SManager.sartir();
    }
    public void azaltS()
    {
        bash_SManager.sazalt();
    }
    public void artiqQ()
    {
        bash_SManager.qArtiq();
    }
    public void azaltQ()
    {
        bash_SManager.Qazalt();
    }
    public void artiqO()
    {
        bash_SManager.OArtir();
    }
    public void azaltO()
    {
        bash_SManager.OAzalt();
    }





}
