using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointReach : MonoBehaviour
{
	public static int _checkpointCount;
	public GameObject _lapContainer;
	private const int MAX_CHECKPOINTS = 13;
	void OnTriggerExit(Collider other)
	{
		
		_checkpointCount++;

		if (_checkpointCount == MAX_CHECKPOINTS )
		{
			_lapContainer.GetComponent<LapComplete>()._lapComplete = true;
			_checkpointCount = 0;
		}

		gameObject.SetActive(false);

	}
}
