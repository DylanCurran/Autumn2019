using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldTextUI : MonoBehaviour
{
    public GameObject _player;
    public Text _shieldText;

    private void Update()
    {
        _shieldText.text = "Shield: " + _player.GetComponent<PlayerController>()._shieldActive;
    }
}
