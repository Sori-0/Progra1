using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSecond : MonoBehaviour
{
    public float speed = 10;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left.normalized * speed * Time.deltaTime);

    }
 
}
