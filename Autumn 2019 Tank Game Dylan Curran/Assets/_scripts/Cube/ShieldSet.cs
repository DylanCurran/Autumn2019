using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldSet : MonoBehaviour
{
    public GameObject _player;

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        _player.GetComponent<PlayerController>()._shieldActive = true;
        Debug.Log(_player.GetComponent<PlayerController>()._shieldActive);
    }
}
