using UnityEngine;
using System.Collections;

public class AutoMove : MonoBehaviour
{
    private Vector3 destination;
    private Vector3 origin;
    public float distance;
    public float velocity;

    void Awake()
    {
        destination = transform.localPosition;
        origin = transform.localPosition;
    }

    void Update()
    {
        if (Vector3.Distance(transform.localPosition, destination) < 1)
        {
            destination = transform.localPosition + Random.onUnitSphere * distance;
            destination.z = 0;

            if (Vector3.Distance(destination, origin) > distance)
            {
                destination = transform.localPosition;
            }
            
        }

        transform.localPosition = Vector3.Lerp(transform.localPosition, destination, Time.deltaTime * velocity);
    }
}
