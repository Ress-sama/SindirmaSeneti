using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.Experimental.Rendering.Universal;

public class draggable : MonoBehaviour, IBeginDragHandler,IDragHandler,IEndDragHandler
{
    Camera MainCamera;
    Vector2 offset;
    public Transform DefaultParent;
    public bool isDraggable=false;
    private GameObject MenimKartlarim,kartlarr, mkartYeri,mLight, mLight1, mLight2, mLight3, mLight4,kartBari;
    private void Awake()
    {
        mkartYeri = GameObject.FindGameObjectWithTag("KartYerim");
        kartBari = GameObject.FindGameObjectWithTag("mKartBarim");
        mLight1 = GameObject.FindGameObjectWithTag("mSagIsiq");
        mLight2 = GameObject.FindGameObjectWithTag("mSolIsiq");
        mLight3 = GameObject.FindGameObjectWithTag("mAsagiIsiq");
        mLight4 = GameObject.FindGameObjectWithTag("mYuxariIsiq");
        mLight = GameObject.FindGameObjectWithTag("mKenarIsiq");
        MenimKartlarim = GameObject.Find("MenimKartlarim");
        kartlarr = GameObject.Find("KartlarPaneli");
        MainCamera = Camera.allCameras[0];

    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        offset=transform.position- MainCamera.ScreenToWorldPoint(eventData.position);
        DefaultParent = transform.parent;
        transform.SetParent(DefaultParent.parent);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        //isDraggable = DefaultParent.GetComponent<DropKartScr>().type == FieldType.OZ_PANELIM;

       
        // x 940  y -918
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (SceneManager.GetActiveScene().name == "Oyun") 
        {
            mkartYeri.SetActive(true);
            mkartYeri.GetComponent<CanvasGroup>().alpha = 1;
            mLight4.GetComponent<Light2D>().intensity = 1;
            mLight.SetActive(true);
        }
        
        
        Vector2 position = MainCamera.ScreenToWorldPoint(eventData.position);
        transform.position = position + offset;
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {

        if (SceneManager.GetActiveScene().name == "Oyun")
        {
            StartCoroutine("dayanSuka");
            transform.SetParent(DefaultParent);
            GetComponent<CanvasGroup>().blocksRaycasts = true;
        }
        if (MenimKartlarim.transform.childCount < 5)
        {
            transform.SetParent(DefaultParent);
            GetComponent<CanvasGroup>().blocksRaycasts = true;
        }
        else
        {
            transform.SetParent(kartlarr.transform);
            GetComponent<CanvasGroup>().blocksRaycasts = true;
        }

        
    }
    IEnumerator dayanSuka()
    {
        yield return new WaitForSeconds(0.2f);
        if (mkartYeri.transform.childCount < 1)
        {
            for (int i = 0; i < 9; i++)
            {              
                mLight4.GetComponent<Light2D>().intensity-=0.1f;
                mkartYeri.GetComponent<CanvasGroup>().alpha -= 0.1f;
                yield return new WaitForSeconds(0.02f);
            }
            mkartYeri.SetActive(false);
            mLight.SetActive(false);
        }
        
    }
}
 
   

