using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    float speed;

    private void Start()
    {
        speed = Random.Range(0.5f, 10);
        Destroy(this.gameObject, 10f);
    }

    private void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + Time.deltaTime * speed, transform.position.z);
    }
}
