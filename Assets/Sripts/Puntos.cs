using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntos : MonoBehaviour
{
    private TMP_Text textComponent;
    private int puntos; 
    void Start()
    {
        textComponent = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textComponent.text = "Puntos: " + puntos;
    }

    public void AddPoints (int value)
    {
        puntos = puntos + 1 + value;
    }
}
