using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;

public class MoveBackgroundLeft : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;

    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2; 
    }

    void Update()
    {
        if (transform.position.x < (startPos.x - repeatWidth))
        {
            transform.position = startPos;
        }
    }
}
