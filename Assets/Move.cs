using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float speed = 1;
    Vector3 direction = new Vector3(0, 0, 1);
    void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(direction.normalized * speed * Time.deltaTime);
    }
    
}
