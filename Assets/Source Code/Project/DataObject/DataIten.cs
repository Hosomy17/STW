using UnityEngine;
using System.Collections;

public class DataIten : DataObjectGeneric
{

    public GameObject effectDie;

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.CompareTag("Earth"))
        {
            //Instantiate(effectDie, transform.position, transform.rotation);
            Destroy(gameObject);
        }  
        if (c.gameObject.CompareTag("Player"))
        {
            Instantiate(effectDie, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        //if(c.gameObject.name == "Edges")
        //{
        //    Rigidbody2D rb = GetComponent<Rigidbody2D>();
        //    Vector2 force = new Vector2(rb.velocity.x, rb.velocity.y);
        //    force *= -500;
        //    rb.AddForce(force);
        //}
    }
}
