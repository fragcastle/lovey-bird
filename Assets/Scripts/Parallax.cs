using UnityEngine;
using System.Collections;

public class Parallax : MonoBehaviour
{
	private Vector3 _startPosition;
	private Transform Target;
	private Vector3 _targetStartPosition;
	
	public string TargetName;
	public Vector3 ParallaxAmount = new Vector3(0.5F, 0.5F, 0);
	
	void Start ()
	{
		_startPosition = transform.position;
		
		var targetGameObject = GameObject.Find(TargetName);
		
		if (targetGameObject == null)
			return;
			
		Target = targetGameObject.transform;
		
		_targetStartPosition = Target.transform.position;
	}
	
	void Update ()
	{
		UpdatePosition();
	}
	
	void UpdatePosition()
	{
		if (Target == null)
			return;
			
		var difference = (Target.position - _targetStartPosition);
		
		transform.position =  _startPosition + new Vector3(difference.x * ParallaxAmount.x, difference.y * ParallaxAmount.y, difference.z * ParallaxAmount.z);
	}
}
