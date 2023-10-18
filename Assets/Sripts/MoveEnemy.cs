using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float speed = 10;
    Vector3 direction = new Vector3(-1, 0, 0);

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right.normalized * speed * Time.deltaTime);
    }
    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
