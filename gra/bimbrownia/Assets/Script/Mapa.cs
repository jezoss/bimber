using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mapa : MonoBehaviour
{

    public GameObject mapas;
    public GameObject mapasPrzycisk;

    public GameObject las1;
    public GameObject las1Przycisk;

    public GameObject wioska1;
    public GameObject wioska1Przycisk;

    public GameObject wioska2;
    public GameObject wioska2Przycisk;

    public GameObject miasto;
    public GameObject miastoPrzycisk;

    // Start is called before the first frame update
    void Start()
    {
        MapaMaByc();
    }

    // Update is called once per frame

    public void MapaMaByc()
    {
        mapas.SetActive(true);
        mapasPrzycisk.SetActive(true);

        las1.SetActive(false);
        las1Przycisk.SetActive(false);

        wioska1.SetActive(false);
        wioska1Przycisk.SetActive(false);

        wioska2.SetActive(false);
        wioska2Przycisk.SetActive(false);

        miasto.SetActive(false);
        miastoPrzycisk.SetActive(false);
    }

    public void Las1()
    {
        mapas.SetActive(false);
        mapasPrzycisk.SetActive(false);

        las1.SetActive(true);
        las1Przycisk.SetActive(true);

        wioska1.SetActive(false);
        wioska1Przycisk.SetActive(false);

        wioska2.SetActive(false);
        wioska2Przycisk.SetActive(false);

        miasto.SetActive(false);
        miastoPrzycisk.SetActive(false);

    }

    public void Las2()
    {
        mapas.SetActive(false);
        mapasPrzycisk.SetActive(false);

        las1.SetActive(false);
        las1Przycisk.SetActive(false);

        wioska1.SetActive(false);
        wioska1Przycisk.SetActive(false);

        wioska2.SetActive(false);
        wioska2Przycisk.SetActive(false);

        miasto.SetActive(false);
        miastoPrzycisk.SetActive(false);
    }
    
    public void Las3()
    {
        mapas.SetActive(false);
        mapasPrzycisk.SetActive(false);

        las1.SetActive(false);
        las1Przycisk.SetActive(false);

        wioska1.SetActive(false);
        wioska1Przycisk.SetActive(false);

        wioska2.SetActive(false);
        wioska2Przycisk.SetActive(false);

        miasto.SetActive(false);
        miastoPrzycisk.SetActive(false);
    }
    
    public void Wioska1()
    {
        mapas.SetActive(false);
        mapasPrzycisk.SetActive(false);

        las1.SetActive(false);
        las1Przycisk.SetActive(false);

        wioska1.SetActive(true);
        wioska1Przycisk.SetActive(true);

        wioska2.SetActive(false);
        wioska2Przycisk.SetActive(false);

        miasto.SetActive(false);
        miastoPrzycisk.SetActive(false);
    }

    public void Wioska2()
    {
        mapas.SetActive(false);
        mapasPrzycisk.SetActive(false);

        las1.SetActive(false);
        las1Przycisk.SetActive(false);

        wioska1.SetActive(false);
        wioska1Przycisk.SetActive(false);

        wioska2.SetActive(true);
        wioska2Przycisk.SetActive(true);

        miasto.SetActive(false);
        miastoPrzycisk.SetActive(false);
    }

    public void Miasto()
    {
        mapas.SetActive(false);
        mapasPrzycisk.SetActive(false);

        las1.SetActive(false);
        las1Przycisk.SetActive(false);

        wioska1.SetActive(false);
        wioska1Przycisk.SetActive(false);

        wioska2.SetActive(false);
        wioska2Przycisk.SetActive(false);

        miasto.SetActive(true);
        miastoPrzycisk.SetActive(true);
    }
}
