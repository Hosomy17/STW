using UnityEngine;
using System.Collections;

public class DataIten : DataObjectGeneric
{

    public GameObject effectDie;
    public string color;

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.CompareTag("Earth"))
        {
            Destroy(gameObject);
        }  
        if (c.gameObject.CompareTag("Player"))
        {
            Instantiate(effectDie, transform.position, transform.rotation);

            if (c.gameObject.transform.parent.GetComponent<DataTrashCan>().color == this.color)
                GameObject.FindGameObjectWithTag("SceneManager").GetComponent<SceneManagerGame>().GainPoints(1);
            
            Destroy(gameObject);
        }
    }
}
