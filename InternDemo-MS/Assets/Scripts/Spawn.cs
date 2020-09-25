using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] prefabs;

    float randX;
    float staticY;
    float staticZ;
    Vector3 whereToSpawn;
    public float repeatTime = 3f;

    
    void Start()
    {
        InvokeRepeating("Spawnn", 2f, repeatTime);
    }

    void Spawnn()
    {
        randX = Random.Range(-0.5f, 0.5f);
        staticY = Random.Range(9, 9);
        staticZ = Random.Range(4, 4);
        whereToSpawn = new Vector3(randX, staticY, staticZ);
        Instantiate(prefabs[Random.Range(0, prefabs.Length)], whereToSpawn, transform.rotation);
    }
}
