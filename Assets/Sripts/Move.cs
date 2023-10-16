using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 10;
    Vector3 direction = new Vector3(1, 0, 0);
    void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(Vector3.right.normalized * speed * Time.deltaTime);
    }
    
}
