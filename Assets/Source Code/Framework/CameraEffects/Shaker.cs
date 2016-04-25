using UnityEngine;
using System.Collections;

public class Shaker : MonoBehaviour {

    private Vector3 directions;
    private Vector3 originPosition;
    public float  intensity;

	void Awake()
    {
        originPosition = transform.localPosition;
    }
	
	void Update ()
    {
        
        directions         = Random.onUnitSphere * intensity;
        directions.z       = originPosition.z;
        transform.localPosition = originPosition + directions;
        //Debug.DrawRay(gameObjectt.transform.position, Random.insideUnitSphere * 20);
	}

    public void Shake(float intensity, float duration)
    {
        this.intensity = intensity;
        StartCoroutine("StopShake", duration);
    }

    private IEnumerator StopShake(float duration)
    {
        yield return new WaitForSeconds(duration);
        this.intensity = 0;
    }
}
