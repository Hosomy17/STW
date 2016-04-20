using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItenSpawner : MonoBehaviour
{
    private List<string> colors;
    public float velocity;
    public Transform target;

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
        //StartCoroutine(RandomPositions(40));
        StartCoroutine(FixedPosition(40));
        //StartCoroutine(TwoOneRandomPositions(40));
        //StartCoroutine(MirroredFixedPosition(40));
        //StartCoroutine(SpradedPositions(40));
    }

    void Update ()
    {}

    public IEnumerator SpradedPositions(int total)
    {
        //3000 é a distancia entre o ponto minimo e maximo de onde o lixo é cridado
        int distance = 3000 / total;
        int limitPointOnCircle = distance;
        Vector2 randomPointOnCircle;

        for (int i = 0; i < total; i++)
        {
            do
            {
                randomPointOnCircle = Random.insideUnitCircle;
                randomPointOnCircle.Normalize();

                if (randomPointOnCircle.y < 0)
                    randomPointOnCircle.y *= -1;

            } while (randomPointOnCircle.x * 1500 < -1500 + limitPointOnCircle - distance || randomPointOnCircle.x * 1500 > -1500 + limitPointOnCircle);

            limitPointOnCircle += distance;
            Spawn(randomPointOnCircle);
            yield return new WaitForSeconds(0.1f);

        }
    }

    public IEnumerator RandomPositions(int total)
    {
        Vector2 randomPointOnCircle;
        for (int i = 0; i < total; i++)
        {
            do
            {
                randomPointOnCircle = Random.insideUnitCircle;
                randomPointOnCircle.Normalize();

                if (randomPointOnCircle.y < 0)
                    randomPointOnCircle.y *= -1;

            } while (randomPointOnCircle.x * 1500 < -1500 || randomPointOnCircle.x * 1500 > 1500);
            Spawn(randomPointOnCircle);
            yield return new WaitForSeconds(1.5f);
        }

        
    }

    public IEnumerator FixedPosition(int total)
    {
        Vector2 randomPointOnCircle;
        do
        {
            randomPointOnCircle = Random.insideUnitCircle;
            randomPointOnCircle.Normalize();

            if (randomPointOnCircle.y < 0)
                randomPointOnCircle.y *= -1;

        } while (randomPointOnCircle.x * 1500 < -1500 || randomPointOnCircle.x * 1500 > 1500);

        for (int i = 0; i < total; i++)
        {
            Spawn(randomPointOnCircle);
            yield return new WaitForSeconds(0.2f);
        }
    }

    public IEnumerator TwoOneRandomPositions(int total)
    {
        Vector2 randomPointOnCircle;
        for (int i = 0; i < total; i++)
        {
            do
            {
                randomPointOnCircle = Random.insideUnitCircle;
                randomPointOnCircle.Normalize();

                if (randomPointOnCircle.y < 0)
                    randomPointOnCircle.y *= -1;

            } while (randomPointOnCircle.x * 1500 < -1500 || randomPointOnCircle.x * 1500 > 1500);

            if (i % 2 == 0)
            {
                Spawn(randomPointOnCircle);
                yield return new WaitForSeconds(0.2f);
            }

            Spawn(randomPointOnCircle);
            yield return new WaitForSeconds(1.5f);
        }
    }

    public IEnumerator MirroredFixedPosition(int total)
    {
        Vector2 randomPointOnCircle;
        do
        {
            randomPointOnCircle = Random.insideUnitCircle;
            randomPointOnCircle.Normalize();

            if (randomPointOnCircle.y < 0)
                randomPointOnCircle.y *= -1;

        } while (randomPointOnCircle.x * 1500 < -1500 || randomPointOnCircle.x * 1500 > 1500);

        for (int i = 0; i < total; i++)
        {
            randomPointOnCircle.x *= -1;
            Spawn(randomPointOnCircle);
            yield return new WaitForSeconds(1.0f);
        }
    }

    public void Spawn(Vector2 position)
    {
        string color = colors[0];

        //Total de itens por cor
        int index = Random.Range(0, 4);
        GameObject aux = Resources.Load("Prefabs/Itens/"+color+"/"+color+"_Itens_"+index) as GameObject;
        aux = Instantiate(aux);
        aux.GetComponent<ClassIten>().color = color;

        aux.transform.position = position * 1500;
        Vector2 direction = target.position - aux.transform.position;
        aux.GetComponent<Rigidbody2D>().AddForce(direction.normalized * velocity);
    }
}