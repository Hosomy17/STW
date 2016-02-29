using UnityEngine;
using System.Collections;

public class ClassIten : ClassGeneric
{

    public GameObject effectDestroy;
    public string color;

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.CompareTag("Earth"))
        {
            Destroy(gameObject);
        }  
        if (c.gameObject.CompareTag("Player"))
        {
            Instantiate(effectDestroy, transform.position, transform.rotation);

            if (c.gameObject.transform.parent.GetComponent<ClassTrashCan>().color == this.color)
                GameObject.FindGameObjectWithTag("SceneManager").GetComponent<ScriptGame>().GainPoints(1);
            
            Destroy(gameObject);
        }
    }
}
