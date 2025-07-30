using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private float jumpForce = 5f;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    [System.Obsolete]
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        if (transform.position.y > 5.5f)
        { 
            transform.position = new Vector3(transform.position.x, 5.5f, transform.position.z);
            playerRb.velocity = new Vector3(playerRb.velocity.x, 0f, playerRb.velocity.z); // Annule la vitesse verticale
        }
    }

    void Jump()
    {
        playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
