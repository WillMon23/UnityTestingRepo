using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothPlayerMovementBehaviour : MonoBehaviour
{
    public float _speed = 1f;

    [SerializeField]
    private float _currentSpeed;

    [SerializeField]
    private float _topSeep;

    private void Update()
    {

        if (Input.GetKey(KeyCode.W))
            transform.position += Vector3.up * Time.deltaTime * _speed;

        if (Input.GetKey(KeyCode.S))
            transform.position -= Vector3.up * Time.deltaTime * _speed;

        if (Input.GetKey(KeyCode.D))
            transform.position += Vector3.right * Time.deltaTime * _speed;

        if (Input.GetKey(KeyCode.A))
            transform.position -= Vector3.right * Time.deltaTime * _speed;
    }
}
