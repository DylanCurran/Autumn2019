using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LapTracker : MonoBehaviour
{
	public GameObject _lapCompleter;
	public TextMeshProUGUI _lapText;
	private int _lapsDone;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
	    _lapsDone = _lapCompleter.gameObject.GetComponent<LapComplete>().GetCount();
	    _lapText.text = "Laps Complete: " + _lapsDone + "/3";
    }
}
