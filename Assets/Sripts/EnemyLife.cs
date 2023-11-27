using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    public int enemyLife = 2;
    private Puntos puntosScript;
    void Start()
    {
        puntosScript = FindObjectOfType<Puntos>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EnemyL()
    {
        enemyLife --;
        if (enemyLife == 0)
        {
            Destroy(gameObject);
            puntosScript.AddPoints(1);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            EnemyL();
        }
    }
}
