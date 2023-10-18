using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    float time = 0;
    public GameObject Enemy;
    void Update()
    {
        float num1 = Random.Range(1, 20);
        float num2 = Random.Range(1, 20);
        Vector3 RandomPosition = new Vector3(num2, num1, 0);
        time -= Time.deltaTime;
        if (time < 0)
        {
            Instantiate(Enemy, RandomPosition, Quaternion.identity);
            time = 1;
            
        }
    }
        void OnCollisionEnter(Collision collision)
        {
            Destroy(gameObject);
        }

}
