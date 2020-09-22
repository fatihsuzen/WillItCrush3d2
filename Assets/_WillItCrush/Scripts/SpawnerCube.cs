using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCube : MonoBehaviour
{
    public List<GameObject> cube = new List<GameObject>();
    float nextSpawn = 0f;
    public static float SpawnCubetime = 1.2f;
    public float minPosY, maxPosY;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            Instantiate(cube[Random.Range(0, cube.Count)], new Vector3(Random.Range(minPosY, maxPosY), 10f, 5f), Quaternion.identity);
            nextSpawn = Time.time + SpawnCubetime;
        }
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(nextSpawn);

        Instantiate(cube[Random.Range(0, cube.Count)], new Vector3(Random.Range(minPosY, maxPosY), 10f, 5f), Quaternion.identity);
        nextSpawn = Time.time + SpawnCubetime;

        StartCoroutine(Spawn());
    }
}
