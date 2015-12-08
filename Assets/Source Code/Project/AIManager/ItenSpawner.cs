using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItenSpawner : MonoBehaviour
{
    public List<GameObject> lstIten;
    public float velocity;
    private GameObject aux;
    
    
    void Start()
    {
        Spawn();
    }

    void Update ()
    {
        

    }

    private void Spawn()
    {

        Vector2 randomPointOnCircle;
        randomPointOnCircle = Random.insideUnitCircle;
        randomPointOnCircle.Normalize();
        
        if (randomPointOnCircle.y < 0)
            randomPointOnCircle.y *= -1;

        //if(randomPointOnCircle.x* 1500 || randomPointOnCircle.x * 1500)
        //{
        //    Spawn();
        //    return;
        //}

        int num = Random.Range(0, lstIten.Count);
        aux = Instantiate(lstIten[num]);
        aux.transform.position = randomPointOnCircle * 1500;
        aux.transform.position = new Vector2(aux.transform.position.x, aux.transform.position.y-450);
        aux.GetComponent<Rigidbody2D>().AddForce(-randomPointOnCircle * velocity);

        Invoke("Spawn", 2);
    }
}