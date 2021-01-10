using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static playerKOD;

public class Bash_SManager : MonoBehaviour
{
    private int sindirma = 0, qoruma = 0, oqlanliq = 0;
    [SerializeField]
    public int maxArt = 6;
    public playerKOD oyuncu;
    public GameObject sText,qText,oText,gosterOglan, _gosterMudafie, _gosterSindir;
    public BashlaButton button;

    public void sartir()
    {
        if (maxArt > 0)
        {
            sindirma += 1;
            maxArt -= 1;
            sText.GetComponent<TextMeshProUGUI>().text = (sindirma.ToString());
        }
    }
    public void sazalt()
    {
        if (sindirma > 0)
        {
            sindirma -=1;
            maxArt += 1;
            sText.GetComponent<TextMeshProUGUI>().text = (sindirma.ToString());

        }
    }
    public void qArtiq()
    {
        if (maxArt > 0)
        {
            qoruma += 1;
            maxArt -= 1;
            qText.GetComponent<TextMeshProUGUI>().text = (qoruma.ToString());
        }
    }
    public void Qazalt()
    {
        if (qoruma > 0)
        {
            qoruma -= 1;
            maxArt += 1;
            qText.GetComponent<TextMeshProUGUI>().text = (qoruma.ToString());
        }
    }
    public void OArtir()
    {
        if (maxArt > 0)
        {
            oqlanliq += 1;
            maxArt -= 1;
            oText.GetComponent<TextMeshProUGUI>().text = (oqlanliq.ToString());
        }
    }
    public void OAzalt()
    {
        if (oqlanliq > 0)
        {
            oqlanliq -= 1;
            maxArt += 1;
            oText.GetComponent<TextMeshProUGUI>().text = (oqlanliq.ToString());
        }
    }


    private void FixedUpdate()
    {
        gosterOglanliq();
        gosterMudafie();
        gosterSindir();
    }

    public void gosterOglanliq() 
    {
        int oglan;
        oglan = oyuncu.mcan + oqlanliq;
        gosterOglan.GetComponent<TextMeshProUGUI>().text = oglan.ToString();

    }
    public void gosterMudafie()
    {
        int oglan;
        oglan = qoruma * 2;
        _gosterMudafie.GetComponent<TextMeshProUGUI>().text = ("Düşmen sözlərine  " + oglan.ToString() + "% Mudafie") ;

    }
    public void gosterSindir()
    {
        int oglan;
        oglan = sindirma * 2;
        _gosterSindir.GetComponent<TextMeshProUGUI>().text = ("Sındırıcı sözlerine  " + oglan.ToString() + "% Etki");

    }

    public void falanFilan()
    {
        ozellikler.elaveCan = oqlanliq;
        ozellikler.qorumaQ = qoruma;
        ozellikler.sindirmaQ = sindirma;
    }
}
