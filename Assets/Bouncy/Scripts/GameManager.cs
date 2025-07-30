using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] objectsToSpawn;
    private int currentObjectIndex;
    private float spawnInterval = 2f;
    private Vector3 spawnPos;


    void Start()
    {
        InvokeRepeating("SpawnObject", 0f, spawnInterval);
    }

    void Update()
    {
    }

    void SpawnObject()
    {
        currentObjectIndex = Random.Range(0, objectsToSpawn.Length);
        spawnPos = new Vector3(-20, Random.Range(-7f, 5.5f), -4.5f);
        Instantiate(objectsToSpawn[currentObjectIndex], spawnPos, objectsToSpawn[currentObjectIndex].transform.rotation);
    }
}
