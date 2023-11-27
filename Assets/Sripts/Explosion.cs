using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject Mina;
    public float min;
    public float max;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float num1 = Random.Range(min, max);
        Vector3 RandomPosition = new Vector3(-10, num1, 0);
        
    }
}
