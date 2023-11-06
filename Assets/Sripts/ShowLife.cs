using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowLife : MonoBehaviour
{
    private TMP_Text textComponent;
    private Spawn spawnScript;
    void Start()
    {
        spawnScript = FindObjectOfType<Spawn>();
        textComponent = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textComponent.text = "Vidas: " + spawnScript.life;
    }
}
