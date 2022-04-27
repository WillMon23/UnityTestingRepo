using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipPlayerMovementBehaviour : MonoBehaviour
{
    public float _speed = 20f;

    [SerializeField]
    private float _currentSpeed;

    [SerializeField]
    private float _topSeep;

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
            transform.position += Vector3.up;

        if (Input.GetKeyDown(KeyCode.S))
            transform.position -= Vector3.up;

        if (Input.GetKeyDown(KeyCode.D))
            transform.position += Vector3.right;

        if (Input.GetKeyDown(KeyCode.A))
            transform.position -= Vector3.right;

    }
}
