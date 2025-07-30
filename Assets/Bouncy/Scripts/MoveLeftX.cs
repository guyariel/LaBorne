using UnityEngine;

public class MoveLeftX : MonoBehaviour
{
    private float speed = 5f;
    void Start()
    {   
    }

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
    }
}
