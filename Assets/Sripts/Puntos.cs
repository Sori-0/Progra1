using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine.SceneManagement;

public class Puntos : MonoBehaviour
{
    private TMP_Text textComponent;
    private int puntos;
    void Start()
    {
        textComponent = GetComponent<TMP_Text>();
    }
    void Update()
    {
        textComponent.text = "Puntos: " + puntos;
    }
    public void AddPoints (int value)
    {
        puntos = puntos + 1 + value;
        if (puntos == 20)
        {
            SceneManager.LoadScene(3);
        }
    }
}
