using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItenSpawner : MonoBehaviour
{
    private List<string> colors;
    public float velocity;

    void Awake()
    {
        colors = new List<string>();
        colors.Add("Blue");
        colors.Add("Green");
        colors.Add("Red");
        colors.Add("Yellow");
    }
    void Start()
    {
        Spawn();
    }

    void Update ()
    {}

    public void Spawn()
    {

        Vector2 randomPointOnCircle;
        randomPointOnCircle = Random.insideUnitCircle;
        randomPointOnCircle.Normalize();
        
        if (randomPointOnCircle.y < 0)
            randomPointOnCircle.y *= -1;

        if (randomPointOnCircle.x * 1500 < -1000 || randomPointOnCircle.x * 1500 > 1000)
        {
            Spawn();
            return;
        }

        int index = Random.Range(0, colors.Count);
        string color = colors[index];

        //Total de itens por cor
        index = Random.Range(0, 4);
        GameObject aux = Resources.Load("Prefabs/Itens/"+color+"/"+color+"_Itens_"+index) as GameObject;
        aux = Instantiate(aux);
        aux.GetComponent<ClassIten>().color = color;

        aux.transform.position = randomPointOnCircle * 1500;
        aux.transform.position = new Vector2(aux.transform.position.x, aux.transform.position.y-450);
        aux.GetComponent<Rigidbody2D>().AddForce(-randomPointOnCircle * velocity);
        Invoke("Spawn", 3);

    }
}