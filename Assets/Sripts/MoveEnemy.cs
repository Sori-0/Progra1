using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float speed = 10;
    private Puntos puntosScript;
    private Spawn spawnScript;
    private void Start()
    {
        puntosScript = FindObjectOfType<Puntos>();
        spawnScript = FindObjectOfType<Spawn>();
    }
    void Update()
    {
        transform.Translate(Vector3.right.normalized * speed * Time.deltaTime);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            spawnScript.Life();
        }
        puntosScript.AddPoints(0);
        Destroy(collision.gameObject);
        Destroy(gameObject);

    }
}
