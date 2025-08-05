using UnityEngine;
using UnityEngine.UIElements;

public class SpinMovement : MonoBehaviour
{
    public float spinSpeed = 5f;
    void Start()
    {
    }

    void Update()
    {
        transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
    }
}
