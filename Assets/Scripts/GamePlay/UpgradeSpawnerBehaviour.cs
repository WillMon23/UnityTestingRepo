using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeSpawnerBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _upgrades;

    //Time till next upgrade
    [SerializeField]
    private float _cooldown;
    //The Count Down to the the next spawn
    private float _spawnTimer;

    // Update is called once per frame
    void Update()
    {
        int spacedRng = Random.Range(0, 10);
        //Creates clone of the game objects 

        if (_spawnTimer >= _cooldown)
        {
            Instantiate(_upgrades[0], new Vector3(transform.position.x + spacedRng, transform.position.y + spacedRng, transform.position.z), Quaternion.identity);
            _spawnTimer = 0; 
        }
        _spawnTimer += Time.deltaTime;

    }
}
