using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TworzenieWyloczniekliku : MonoBehaviour
{

    public GameObject BJ1;
    public GameObject BJ2;

    void Update()
    {
    }

    void Czekaj()
    {
        BJ1.SetActive(false);
        BJ2.SetActive(false);
    }

    void Wracaj()
    {
        BJ1.SetActive(true);
        BJ2.SetActive(true);
    }
}
