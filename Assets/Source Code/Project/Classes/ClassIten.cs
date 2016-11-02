using UnityEngine;
using System.Collections;

public class ClassIten : ClassGeneric
{

    public GameObject effectDestroy;

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
            
            Destroy(gameObject);
        }
    }
}
