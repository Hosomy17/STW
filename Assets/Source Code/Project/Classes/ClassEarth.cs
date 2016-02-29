using UnityEngine;
using System.Collections;

public class ClassEarth : ClassGeneric
{
    public ControllerEarth controllerEarth;
    public ControllerTrashCan controllerTrashCan;
    void Awake()
    {
        controllerEarth = new ControllerEarth();
    }

    void Start()
    {
        controllerTrashCan = GameObject.Find("Main/Player/Trash Can").GetComponent<ClassTrashCan>().controllerTrashCan;
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        if(c.gameObject.CompareTag("Iten"))
        {
            controllerEarth.Hurt();
            controllerTrashCan.Hurt();
        }
    }
}
