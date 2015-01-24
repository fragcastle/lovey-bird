﻿using UnityEngine;
using System.Collections;

public class KillTrigger : MonoBehaviour
{
	void Start ()
	{
	
	}
	
	void Update ()
	{
	
	}
	
	void OnTriggerEnter2D(Collider2D collision2D)
	{
		var playerController = collision2D.GetComponent<PlayerController>();
		
		if (playerController != null && !playerController.IsDead)
			playerController.OnDeath();
			
		if (PlatformDirector.Current)
			PlatformDirector.Current.audio.Play();
	}
}
