using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedBoost : MonoBehaviour
{

    public GameObject _player;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        _player.GetComponent<PlayerController>()._speed = 120;
    }
}
