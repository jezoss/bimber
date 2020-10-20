using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class IleCzegoMamy : MonoBehaviour
{

    public float Pieniadze;
    public int Butelki;
    public int Drozdze;
    public int Cukier;
    public int Woda;
    /*Piersza liczba jest by nazwyac owoce
      0 to jablko
      1 to Gruszka
      3 to Pigwy
      4 to Wisnie
      5 to Czeresnie
      6 to Sliwki
      7 to Aranie
      8 to Truskawka
      9 to Porzeczka
      10 to Winogrona
      11 to 
      12 to 
      13 to 
      14 to 

        Druga liczba jest by składniki rozdzielac
        0 KG owoca
        1 KG zacieru owoca
        2 Litry dobrego alkoholu z danego owocu
        3 litry skaronego alkoholu z danego owocu
    
    */
    public int[,] Owoce = new int[10, 4]
    {
        { 3, 2, 3, 4 }, //0
        { 6, 12, 3, 4 }, //1
        { 3, 2, 3, 4 }, //2
        { 3, 2, 3, 4 }, //3
        { 3, 2, 3, 4 }, //4
        { 3, 2, 3, 4 }, //5
        { 3, 2, 3, 4 }, //6
        { 3, 2, 3, 4 }, //7
        { 3, 2, 3, 4 }, //8
        { 5, 6, 5, 9 }  //9
    };
}
