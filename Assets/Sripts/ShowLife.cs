using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowLife : MonoBehaviour
{
    private TMP_Text textComponent;
    private Spawn spawnScript;
    private int life = 3;
    void Start()
    {
        spawnScript = FindObjectOfType<Spawn>();
    }

    // Update is called once per frame
    void Update()
    {
        textComponent.text = "Vidas: " + spawnScript.life;
    }
    public void SeeLife()
    {
        //spawnScript.life;    
    }
}
