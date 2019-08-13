using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthTextUI : MonoBehaviour
{
    public GameObject _player;
    public Text _healthText;

    private void Update()
    {
        _healthText.text = "Health: " + _player.GetComponent<PlayerController>()._health;
    }
}
