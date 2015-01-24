using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
    public Vector3 Direction = new Vector3(1, 0, 0);
    public float Speed = 0.1F;
    
    void Start()
    {
    	if (Direction.x < 0)
    		transform.localScale = new Vector3(-1, 1, 1);
    }
    
    void Update()
    {
		transform.position = transform.position + (Time.deltaTime * Speed * Direction); //new Vector2(transform.position.x , transform.position.y);
    }
}
