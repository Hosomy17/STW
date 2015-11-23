using UnityEngine;
using System.Collections;

public class Shaker : MonoBehaviour {

    private Vector3 directions;
    private Vector3 originPosition;
    public float intensity;
	void Awake()
    {
        originPosition = transform.position;
    }
	
	// Update is called once per frame
	void Update ()
    {
        directions = Random.insideUnitSphere * intensity;
        directions.z = originPosition.z;
        transform.position = originPosition + directions;
	}
}
