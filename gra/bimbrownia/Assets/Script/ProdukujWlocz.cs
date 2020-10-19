using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProdukujWlocz : MonoBehaviour
{
    public GameObject EkwipunekProdukcji;

    public void EkwipunekProdukcyjny()
    {
        EkwipunekProdukcji.SetActive(true);
    }

    public void EkwipunekProdukcyjnyWylocz()
    {
        EkwipunekProdukcji.SetActive(false);
    }
}
