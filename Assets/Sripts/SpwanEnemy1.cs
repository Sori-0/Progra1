using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanEnemy1 : MonoBehaviour
{
    float time = 0;
    public GameObject Enemy;
    public float min;
    public float max;

    void Update()
    {
        float num1 = Random.Range(min, max);
        Vector3 RandomPosition = new Vector3(-10, num1, 0);
        time -= Time.deltaTime;

        if (time <= 0)
        {
            Instantiate(Enemy, RandomPosition, Quaternion.identity);
            time = 8;
        }
    }
}
