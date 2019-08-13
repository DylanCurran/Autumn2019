using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointReach : MonoBehaviour
{
	public static int _checkpointCount;
	public GameObject _lapContainer;
	private const int MAX_CHECKPOINTS = 13;
	void OnTriggerEnter(Collider other)
	{
		
		_checkpointCount++;
		Debug.Log(_checkpointCount);

		if (_checkpointCount == MAX_CHECKPOINTS )
		{
			_lapContainer.GetComponent<LapComplete>()._lapComplete = true;
		}

		gameObject.SetActive(false);

	}
}
