using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShieldTracker : MonoBehaviour
{
	public GameObject _player;

	[SerializeField] private TextMeshProUGUI _shieldText;

	private bool _shieldStore;
    // Update is called once per frame
    void Update()
    {
	    _shieldStore = _player.GetComponent<PlayerController>().GetShield();
	    _shieldText.text = "Shield Active: " + _shieldStore;
    }
}
