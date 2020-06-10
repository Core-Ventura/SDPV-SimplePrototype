using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSpawn : MonoBehaviour
{
    public GameObject balloonPrefab;

    public float radius;
    public float frequency;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0f, frequency);
    }

    void Spawn()
    {
        Vector3 spawnPos = new Vector3(1, 0, 0) * Random.Range(-radius, radius);
        spawnPos.y = Random.Range(-5, -10);
        GameObject balloonI = Instantiate(balloonPrefab, spawnPos, Quaternion.identity);
        balloonI.transform.localScale *= Random.Range(0.1f, 1f);
    }
}
