using UnityEngine;
using System.Collections;

public class BounceMailboxArrow : MonoBehaviour
{
    public float MovementDistance = 3f;
    public float MovementSpeed = 3f;

    private float minY;
    private float maxY;

    private int direction = 1;

    // Use this for initialization
    void Start()
    {
        maxY = transform.position.y + (MovementDistance / 2);
        minY = transform.position.y - (MovementDistance / 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= maxY)
        {
            direction = -1;
        }

        if (transform.position.y <= minY)
        {
            direction = 1;
        }

        transform.position = new Vector3(transform.position.x, transform.position.y + (MovementSpeed * Time.deltaTime * direction), transform.position.z);
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, new Vector3(transform.position.x, maxY, transform.position.z));
        Gizmos.DrawLine(transform.position, new Vector3(transform.position.x, minY, transform.position.z));
    }
}
