using UnityEngine;

public class MoveLeftX : MonoBehaviour
{
    public float speed = 5f;
    PlayerController playerController;
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();   
    }

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);

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
            speed = 0f;
        }
    }
}
