using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItenSpawner : MonoBehaviour
{
    public List<GameObject> lstItenBlue;
    public List<GameObject> lstItenGreen;
    public List<GameObject> lstItenRed;
    public List<GameObject> lstItenYellow;
    public float velocity;
    private GameObject aux;
    
    void Start()
    {
    }

    void Update ()
    {
        

    }

    private void Spawn(List<GameObject> lstIten)
    {

        Vector2 randomPointOnCircle;
        randomPointOnCircle = Random.insideUnitCircle;
        randomPointOnCircle.Normalize();
        
        if (randomPointOnCircle.y < 0)
            randomPointOnCircle.y *= -1;

        if (randomPointOnCircle.x * 1500 < -1000 || randomPointOnCircle.x * 1500 > 1000)
        {
            Spawn(lstIten);
            return;
        }

        int num = Random.Range(0, lstIten.Count);
        aux = Instantiate(lstIten[num]);

        aux.transform.position = randomPointOnCircle * 1500;
        aux.transform.position = new Vector2(aux.transform.position.x, aux.transform.position.y-450);
        aux.GetComponent<Rigidbody2D>().AddForce(-randomPointOnCircle * velocity);
    }
}