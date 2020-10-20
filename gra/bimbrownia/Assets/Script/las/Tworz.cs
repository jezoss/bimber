using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using System;


public class Tworz : MonoBehaviour
{
    public string Nazwa;
    public int KtoryOwocbierze;
    public Text KgJablek;
    public Text KgJablekZacier;
    public Text Tytul;

    public IleCzegoMamy _Ile;
    public bool CzyMamyWszystko;
    private int Kg;
    private int KgZ;
    public Button Przycisk;

    public Button PrzyciskBimber;
    public bool CzyMamyWszystkoBimber;
    public int SzansaNaZlyWybur;
    public int ZlyWyrub;
    public int SzansaNaWybuchAparatury;
    public int Wybuch;

    public Slider BarB;
    public float MaxCzasu;
    public float IleJeszczeCzasuPozostalo;

    public GameObject Menager;

    //  public string NazwaTabelki = "Jab";
    // Start is called before the first frame update
    void Start()
    {
        _Ile = GameObject.FindObjectOfType<IleCzegoMamy>();
        Przycisk.onClick.AddListener(TaskOnClick);
        PrzyciskBimber.onClick.AddListener(TaskOnClickBimber);
        Kg = _Ile.Owoce[KtoryOwocbierze, 0];
        KgZ = _Ile.Owoce[KtoryOwocbierze, 1];
        CzyMamyWszystko = false;
        CzyMamyWszystkoBimber = false;

        IleJeszczeCzasuPozostalo = MaxCzasu;


    }

    // Update is called once per frame
    void Update()
    {
        Tytul.text = Nazwa;
        KgJablek.text = Nazwa + "  " + Kg + "kg";
        KgJablekZacier.text = "Zacier  " + KgZ + "kg";
        Kg = _Ile.Owoce[KtoryOwocbierze, 0];
        KgZ = _Ile.Owoce[KtoryOwocbierze, 1];

        if (CzyMamyWszystko == true)
        {
            TimersZacieru();
            if (IleJeszczeCzasuPozostalo <= 0)
            {
                ProdukujeZacier();
            }
        }


        if (CzyMamyWszystkoBimber == true)
        {
            TimersBimbru();
            if (IleJeszczeCzasuPozostalo <= 0)
            {
                ProdukujeBimber();
            }
        }
    }

    void TimersZacieru()
    {
        Menager.SendMessage("Czekaj", true);
        IleJeszczeCzasuPozostalo -= Time.deltaTime / 0.2f;
        BarB.value = IleJeszczeCzasuPozostalo / MaxCzasu;

    }

    void TaskOnClick()
    {
        Mam();
    }

    void Mam()
    {
        if (_Ile.Owoce[KtoryOwocbierze, 0] >= 1 && _Ile.Woda >= 2 && _Ile.Cukier >= 1 && _Ile.Drozdze >= 1)
        {
            _Ile.Owoce[KtoryOwocbierze, 0] = _Ile.Owoce[KtoryOwocbierze, 0] - 1;
            _Ile.Woda = _Ile.Woda - 2;
            _Ile.Cukier = _Ile.Cukier - 1;
            _Ile.Drozdze = _Ile.Drozdze - 1;

            CzyMamyWszystko = true;
        }
        else
        {
            Debug.Log("BrakSkładników");
        }
    }

    void ProdukujeZacier()
    {  
       _Ile.Owoce[KtoryOwocbierze, 1] = _Ile.Owoce[KtoryOwocbierze, 1] + 1;
        IleJeszczeCzasuPozostalo = MaxCzasu;
       CzyMamyWszystko = false;
       Debug.Log("Wyprudokowane Zacier");
        Menager.SendMessage("Wracaj", true);

    }


    //Produkowanie Bimbru
    void TaskOnClickBimber()
    {
        MamBimber();
    }

    void TimersBimbru()
    {
        Menager.SendMessage("Czekaj", true);
        IleJeszczeCzasuPozostalo -= Time.deltaTime / 1f;
        BarB.value = IleJeszczeCzasuPozostalo / MaxCzasu;

    }

    void MamBimber()
    {
        if (_Ile.Owoce[KtoryOwocbierze, 1] >= 1 && _Ile.Woda >= 1)
        {
            _Ile.Owoce[KtoryOwocbierze, 1] = _Ile.Owoce[KtoryOwocbierze, 1] - 1;
            _Ile.Woda = _Ile.Woda - 2;
            Losowanie();
            CzyMamyWszystkoBimber = true;
        }
        else
        {
            Debug.Log("BrakSkładników");
        }
    }

    void ProdukujeBimber()
    {
        //Debug.Log("dOSZLEM");
        if (ZlyWyrub == 0)
        {
            _Ile.Owoce[KtoryOwocbierze, 3] = _Ile.Owoce[KtoryOwocbierze, 3] + 1;
            IleJeszczeCzasuPozostalo = MaxCzasu;
            CzyMamyWszystkoBimber = false;
            Debug.Log("Wyprudokowane Bimber Skarzony");
            Menager.SendMessage("Wracaj", true);
        }
        else if (Wybuch == 0)
        {
            IleJeszczeCzasuPozostalo = MaxCzasu;
            CzyMamyWszystkoBimber = false;
            Debug.Log("Wybuchlo wszystko w pizde");
            Menager.SendMessage("Wracaj", true);
        }
        else
        {
            IleJeszczeCzasuPozostalo = MaxCzasu;
            _Ile.Owoce[KtoryOwocbierze, 2] = _Ile.Owoce[KtoryOwocbierze, 2] + 1;
            CzyMamyWszystkoBimber = false;
            Debug.Log("Wyprudokowane Bimber");
            Menager.SendMessage("Wracaj", true);
        }
    }

    void Losowanie()
    {
        ZlyWyrub = Random.Range(0 ,  SzansaNaZlyWybur);
        Wybuch = Random.Range(0 , SzansaNaWybuchAparatury);
    }



}
