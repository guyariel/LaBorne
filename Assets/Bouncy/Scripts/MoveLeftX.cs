using UnityEngine;

public class MoveLeftX : MonoBehaviour
{
    PlayerController playerController;
    GameManager gameManager;
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>(); 
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();  
    }

    void Update()
    {
        transform.Translate(Vector3.left * gameManager.moveSpeed * Time.deltaTime, Space.World);

        if (gameObject.CompareTag("Money") && transform.position.x < -55f)
        {
            Destroy(gameObject);
        }
        else if (gameObject.CompareTag("Bomb") && transform.position.x < -55f)
        {
            Destroy(gameObject);
        }

        if (playerController.isGameOver == true)
        {
            gameManager.moveSpeed = 0f;
        }
    }
}
