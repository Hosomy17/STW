using UnityEngine;
using System.Collections;

public class DataIten : DataObjectGeneric
{
    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.CompareTag("Earth"))
            Destroy(gameObject);
        if (c.gameObject.CompareTag("Player"))
            Destroy(gameObject);
    }
}
