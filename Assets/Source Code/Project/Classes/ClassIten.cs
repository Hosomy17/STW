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
            ClassTrashCan player = c.gameObject.transform.parent.GetComponent<ClassTrashCan>();
            player.controllerTrashCan.Point();

            Instantiate(effectDestroy, transform.position, transform.rotation);

            if (player.color == this.color)
                GameObject.FindGameObjectWithTag("SceneManager").GetComponent<ScriptGame>().GainPoints(1);
            
            Destroy(gameObject);
        }
    }
}
