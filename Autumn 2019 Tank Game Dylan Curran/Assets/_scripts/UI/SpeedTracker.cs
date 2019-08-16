using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using TMPro;
using UnityEngine;

public class SpeedTracker : MonoBehaviour
{
	public GameObject _player;

	[SerializeField] private TextMeshProUGUI _speedText;

	private float _speedStore;
    // Update is called once per frame
    void Update()
    {
	    _speedStore = _player.GetComponent<PlayerController>().GetSpeed();
	    _speedText.text = "Current Speed: " + _speedStore;
    }
}
