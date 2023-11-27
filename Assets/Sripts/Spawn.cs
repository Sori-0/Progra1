using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Jobs;

public class Spawn : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float speed;
    public int life = 3;
    public GameObject mina;
    public float min;
    public float max;
    
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
        if (life == 0)
        {
            SceneManager.LoadScene(2);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Power Up")
        {
            Destroy(collision.gameObject);
            life++;
        }
        if (collision.gameObject.tag == "Explosion")
        {
            Destroy(collision.gameObject);
            if (life <= 0)
            {
                float num1 = Random.Range(min, max);
                Vector3 RandomPosition = new Vector3(-10, num1, 0);
                Instantiate(mina, RandomPosition, Quaternion.identity);
            }
        }
    }
}


