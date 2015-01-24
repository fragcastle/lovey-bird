using UnityEngine;
using System.Collections;

public class SplashScreen : MonoBehaviour
{
	void Start ()
	{
		StartCoroutine("StartGame");
	}
	
	void Update ()
	{
		if (Input.touchCount > 0)
		{
			Application.LoadLevel("start");
		}
	}
	
	IEnumerator StartGame()
	{
		yield return new WaitForSeconds(5);
		
		Application.LoadLevel("start");
    }
}
