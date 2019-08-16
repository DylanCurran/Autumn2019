using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthTracker : MonoBehaviour
{
	[SerializeField] private GameObject _player;
	private float _storeHealth;
	[SerializeField] private TextMeshProUGUI _healthText;

    // Update is called once per frame
    void Update()
    {
	    _storeHealth = _player.GetComponent<PlayerController>().GetHealth();
	    _healthText.text = "Current Health: " + _storeHealth;
    }
}
