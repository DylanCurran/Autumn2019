using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeTracker : MonoBehaviour
{
	private double _timer;
	[SerializeField] private TextMeshProUGUI _timerText;

    // Update is called once per frame
    void Update()
    {
	    
	    _timer += Time.deltaTime;
	    _timer = Math.Round(_timer, 2);
	    _timerText.text = "Current Time: " + _timer;
    }
}
