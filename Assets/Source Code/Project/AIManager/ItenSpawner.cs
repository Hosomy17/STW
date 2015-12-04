using UnityEngine;
using System.Collections;

public class ItenSpawner : MonoBehaviour
{
    public GameObject iten;
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

        if(randomPointOnCircle.x* 15 < -9 || randomPointOnCircle.x* 15 > 9)
        {
            Spawn();
            return;
        }

        aux = Instantiate(iten);
        aux.transform.position = randomPointOnCircle * 15;
        aux.transform.position = new Vector2(aux.transform.position.x, aux.transform.position.y-4.5f);
        aux.GetComponent<Rigidbody2D>().AddForce(-randomPointOnCircle*200);

        Invoke("Spawn", 4);
    }
}