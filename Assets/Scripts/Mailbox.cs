using UnityEngine;
using System.Collections;

public class Mailbox : MonoBehaviour
{
	public Sprite HasMail;
	
	void Start ()
	{
		
	}
	
	void Update ()
	{
		
	}
	
	void OnTriggerEnter2D(Collider2D collision2D)
	{
		var playerController = collision2D.GetComponent<PlayerController>();
		
		playerController.ObstaclesPassed++;
		
		audio.Play();
		
		GetComponent<SpriteRenderer>().sprite = HasMail;
		
		GetComponentInChildren<ParticleSystem>().Play();
		
		collider2D.enabled = false;
	}
}
