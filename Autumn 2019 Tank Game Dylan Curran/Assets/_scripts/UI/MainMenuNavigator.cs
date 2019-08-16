using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuNavigator : MonoBehaviour
{
	public void PlayButton()
	{
		SceneManager.LoadScene(1);
	}

	public void ExitButton()
	{
		Debug.Log("Quit");
	}

	public void ReturnToMenu()
	{
		SceneManager.LoadScene(0);
	}
}
