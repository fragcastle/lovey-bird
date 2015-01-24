using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartScreen : BaseBehavior
{
	void Start ()
	{
		Application.targetFrameRate = 300;
	}

	void Update ()
	{
		
	}

	public void StartGame()
	{
		Application.LoadLevel("level-01");
	}
}
