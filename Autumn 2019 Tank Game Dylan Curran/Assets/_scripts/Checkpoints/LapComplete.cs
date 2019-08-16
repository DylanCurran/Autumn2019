using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapComplete : MonoBehaviour
{
	public bool _lapComplete;
	private const int MAX_LAPS = 3;
	private const int MAX_CHECKPOINTS = 13;
	private int _count;

	[SerializeField] private GameObject _GameOverScreen;
	[SerializeField] private GameObject _UIScreen;
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
			for (int i = 0; i < MAX_CHECKPOINTS; i++)
			{
				transform.GetChild(i).gameObject.SetActive(true);
			}
		    _count++;
		    _lapComplete = false;
	    }

	    if (_count >= MAX_LAPS)
	    {
			_UIScreen.SetActive(false);
			_GameOverScreen.SetActive(true);
			Debug.Log("Game Over");
	    }
    }

    public int GetCount()
    {
	    return _count;
    }
}
