using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanCameraScrollBehaviour : MonoBehaviour
{
    [SerializeField]
    private Transform[] _trashold;

    [SerializeField]
    Transform _playerLocation;

    [SerializeField]
    private float _newHieghtLoation;

    [SerializeField]
    private float _panOutSpeed = 1;

    private float _canMove = 0;

    private float _totalhieght;
    // Update is called once per frame
    void Update()
    {
        foreach (Transform lines in _trashold)
        { 
            if (_playerLocation.position.y >= lines.position.y)
            {
                _totalhieght = lines.position.y + _newHieghtLoation;
                transform.position = new Vector3(transform.position.x, transform.position.y + Time.deltaTime * _canMove, transform.position.z);


                if (transform.position.y <= _totalhieght)
                    _canMove = _panOutSpeed;

                else
                    _canMove = 0;
                
            }
        }
    }
}
