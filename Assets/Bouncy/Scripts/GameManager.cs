using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] objectsToSpawn;
    private int currentObjectIndex;
    private float spawnInterval = 2f;
    private Vector3 spawnPos;
    PlayerController playerController;
    public float moveSpeed = 5f;
    public float speedIncreaseRate = 0.2f;


    void Start()
    {
        InvokeRepeating("SpawnObject", 0f, spawnInterval);
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        if (playerController.isGameOver == true)
        {
            GameOver();
        }
        else
        {
            // Increase speed over time
            moveSpeed += speedIncreaseRate * Time.deltaTime;
        }
    }

    void SpawnObject()
    {
        currentObjectIndex = Random.Range(0, objectsToSpawn.Length);
        spawnPos = new Vector3(-20, Random.Range(-7f, 5.5f), -4.5f);
        Instantiate(objectsToSpawn[currentObjectIndex], spawnPos, objectsToSpawn[currentObjectIndex].transform.rotation);
    }

    void GameOver()
    {
        CancelInvoke("SpawnObject");
    }
}
