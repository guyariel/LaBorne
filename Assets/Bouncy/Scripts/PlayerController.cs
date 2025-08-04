using JetBrains.Annotations;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private float jumpForce = 5f;
    public bool isGameOver = false;
    public ParticleSystem explosionParticle;
    public ParticleSystem moneyParticle;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    [System.Obsolete]
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isGameOver)
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

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bomb"))
        {
            isGameOver = true;
            Destroy(other.gameObject);
            ParticleSystem explosionInstance = Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            Destroy(explosionInstance.gameObject, 2f);
        }

        else if (other.gameObject.CompareTag("Money"))
        {
            Destroy(other.gameObject);
            ParticleSystem moneyInstance = Instantiate(moneyParticle, transform.position, moneyParticle.transform.rotation);
            Destroy(moneyInstance.gameObject, 2f);
        }
    }
}
