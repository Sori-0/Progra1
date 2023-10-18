using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 10;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(Vector3.left.normalized * speed * Time.deltaTime);
    }
    
}
