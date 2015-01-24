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
	
	}
	
	IEnumerator StartGame()
	{
		yield return new WaitForSeconds(5);
		
		Application.LoadLevel("start");
    }
}
