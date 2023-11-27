using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.Requests;
using UnityEngine;

public class BulletA : MonoBehaviour
{
    
    float time = 0;
    public GameObject BulletPower1;
    public float min;
    public float max;
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        float num1 = Random.Range(min, max);
        Vector3 RandomPosition = new Vector3(-20, num1, 0);
        time -= Time.deltaTime;

        if (time <= 0)
        {
            Instantiate(BulletPower1, RandomPosition, Quaternion.identity);
            time = 10;
        }
        
    }
    
}
