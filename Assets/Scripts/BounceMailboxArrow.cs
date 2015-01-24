using UnityEngine;
using System.Collections;

public class BounceMailboxArrow : MonoBehaviour
{
    public float MovementDistance = 3f;
    public float MovementTime = 3f;

    private float minY;
    private float maxY;

    private int direction = 1;

    void Start()
    {
        maxY = transform.position.y + (MovementDistance / 2);
        minY = transform.position.y - (MovementDistance / 2);
        
		iTween.MoveTo(gameObject,iTween.Hash("y", minY, "time", MovementTime / 2, "easetype", "easeinQuad", "oncomplete", "MoveUp"));
    }

    void Update()
    {
    
	}
	
	void MoveUp()
	{
		iTween.MoveTo(gameObject,iTween.Hash("y", maxY, "time", MovementTime, "easetype", "easeOutQuad", "oncomplete", "MoveDown"));
	}
	
	void MoveDown()
	{
		iTween.MoveTo(gameObject,iTween.Hash("y", minY, "time", MovementTime, "easetype", "easeinQuad", "oncomplete", "MoveUp"));
	}

    void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, new Vector3(transform.position.x, maxY, transform.position.z));
        Gizmos.DrawLine(transform.position, new Vector3(transform.position.x, minY, transform.position.z));
    }
}
