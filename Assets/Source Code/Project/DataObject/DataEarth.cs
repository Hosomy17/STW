using UnityEngine;
using System.Collections;

public class DataEarth : DataObjectGeneric
{
    public ControllerEarth controllerEarth;
    void Awake()
    {
        controllerEarth = new ControllerEarth();
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        if(c.gameObject.CompareTag("Iten"))
        {
            controllerEarth.Hurt();
        }
    }
}
