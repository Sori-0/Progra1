using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 10;
    private EnemyLife enemylifeScript;

    void Start()
    {
        enemylifeScript = GetComponent<EnemyLife>();
    }
    void Update()
    {
        transform.Translate(Vector3.left.normalized * speed * Time.deltaTime);
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Enemy1")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }

}
