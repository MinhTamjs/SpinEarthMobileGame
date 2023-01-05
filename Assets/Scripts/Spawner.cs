using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] objectToSpawn;
    public float maxX;
    public float maxY;
    public float minX;
    public float minY;
    public float spawnInterval; // kho?ng cách spawn gi?a m?i l?n spawn
    private float spawnTimer; //kho?ng th?i gian t? m?i l?n spawn
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime; // t?ng counter spawn theo th?i gian th?c
        if(spawnTimer >= spawnInterval)
        {
            spawnTimer = 0;
            int randomIndex = Random.Range(0, objectToSpawn.Length);
            GameObject objectsToSpawn = objectToSpawn[randomIndex];
            Vector2 randomPosition = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
            Instantiate(objectsToSpawn, randomPosition, Quaternion.identity);
        }
    }
}
