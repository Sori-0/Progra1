using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    float time = 0;
    public GameObject enemyBullet;
    Vector3 bulletposition = new Vector3(0, 0, 0);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Disparo();
    }
    void Disparo()
    {
        if (time <= 0)
        {
            Instantiate(enemyBullet, bulletposition , Quaternion.identity);
            time = 10;
        }
    }
}
