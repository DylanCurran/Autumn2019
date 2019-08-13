using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapComplete : MonoBehaviour
{
	public bool _lapComplete;

	private int _count;
    // Start is called before the first frame update
    void Start()
    {
	    _lapComplete = false;
    }

    // Update is called once per frame
    void Update()
    {
	    if (_lapComplete)
	    {
			Debug.Log("lap complete");
		    _count++;
		    _lapComplete = false;
	    }
    }
}
