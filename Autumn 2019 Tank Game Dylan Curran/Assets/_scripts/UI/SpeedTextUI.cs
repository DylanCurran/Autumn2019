using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedTextUI : MonoBehaviour
{
    public GameObject _player;
    public Text _speedText;
    // Update is called once per frame
    void Update()
    {
        _speedText.text = "Speed: " + _player.GetComponent<PlayerController>()._speed;
    }
}
