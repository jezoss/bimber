using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zegar : MonoBehaviour

{
    private const float PrzyspieszenieCzasu = 120f;

    private Transform SkazowkaMinutowa;
    private Transform SkazowkaGodzina;
    private Text ZegarCyfrowy;

    public float day;

    void Awake()
    {
        SkazowkaMinutowa = transform.Find("SkazuwkaDługa");
        SkazowkaGodzina = transform.Find("SkazuwkaKrotka");
        ZegarCyfrowy = transform.Find("ZegarCyfrowy").GetComponent<Text>();
       
    }

    // Update is called once per frame
    void Update()
    {
        day += Time.deltaTime / PrzyspieszenieCzasu;

        float dayNormalized = day % 1f;

        float rotationDegreesPerDay = 360f;
        SkazowkaMinutowa.eulerAngles = new Vector3(0, 0, -dayNormalized * rotationDegreesPerDay);

        float hoursPerDay = 24f;
        SkazowkaGodzina.eulerAngles = new Vector3(0, 0, -dayNormalized * rotationDegreesPerDay * hoursPerDay);

        string hoursString = Mathf.Floor(dayNormalized * hoursPerDay).ToString("00");

        float minutesPerHour = 60f;
        string minutesString = Mathf.Floor(((dayNormalized * hoursPerDay) % 1f) * minutesPerHour).ToString("00");

        ZegarCyfrowy.text = hoursString + ":" + minutesString;

    }
}
