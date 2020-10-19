using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProdukujWlocz : MonoBehaviour
{
    public GameObject EkwipunekProdukcji;
    public GameObject UlepszenieEkwip;

    public void EkwipunekProdukcyjny()
    {
        EkwipunekProdukcji.SetActive(true);
    }

    public void EkwipunekProdukcyjnyWylocz()
    {
        EkwipunekProdukcji.SetActive(false);
    }

    //
    public void UlepszenieE()
    {
        UlepszenieEkwip.SetActive(true);
    }

    public void UlepszenieEWylocz()
    {
        UlepszenieEkwip.SetActive(false);
    }
}
