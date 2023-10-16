using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{

    public GameObject Enemy;
    void Update()
    {
        float num1 = Random.Range(1,92);
        Vector3 RandomPosition = new Vector3(num1, 0, 0);
        Instantiate(Enemy, RandomPosition , Quaternion.identity);
    }

}
