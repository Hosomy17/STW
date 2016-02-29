using UnityEngine;
using System.Collections;

public class Shaker : MonoBehaviour {

    private Vector3 directions;
    private Vector3 originPosition;
    private float   intensity;
    private GameObject gameObjectt;

	void Awake()
    {
        originPosition = transform.position;
        gameObjectt = (GameObject) GameObject.Find("Background/Earth");
    }
	
	// Update is called once per frame
	void Update ()
    {
        
        directions         = Random.onUnitSphere * intensity;
        directions.z       = originPosition.z;
        transform.position = originPosition + directions;
        //Debug.DrawRay(gameObjectt.transform.position, Random.insideUnitSphere * 20);
	}

    public void Shake(float intensity, float duration)
    {
        this.intensity = intensity;
        StartCoroutine("StopShake", duration);
        GetComponent<PixelBoy>().enabled = true;
    }

    private IEnumerator StopShake(float duration)
    {
        yield return new WaitForSeconds(duration);
        this.intensity = 0;
        GetComponent<PixelBoy>().enabled = false;
    }
}
