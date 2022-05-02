using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCatchUpBehaviour : MonoBehaviour
{
    [SerializeField]
    private Transform _player;

    [SerializeField]
    private Transform _camera;

    [SerializeField]
    private float _hieghtChange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_player.position.y >= transform.position.y && _camera.position.y <= transform.position.y + _hieghtChange)
            _camera.position = new Vector3(transform.position.x, transform.position.y + Time.deltaTime, transform.position.z);
    }
}
