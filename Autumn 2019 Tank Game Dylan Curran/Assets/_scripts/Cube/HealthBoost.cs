using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBoost : MonoBehaviour
{
    public GameObject _player;
    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        _player.GetComponent<PlayerController>()._health = 200;
    }
}
