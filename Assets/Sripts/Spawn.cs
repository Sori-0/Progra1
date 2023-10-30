using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawn : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float speed;
    public int life = 3;

    void Start()
    {
       
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(objectToSpawn, transform.position , Quaternion.identity);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up.normalized * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down.normalized * speed * Time.deltaTime);
        }
        
    }
    public void Life ()
    {
        life = life - 1;
        if (life == 0)
        {
            Destroy(gameObject);
        }
    }
    
}


