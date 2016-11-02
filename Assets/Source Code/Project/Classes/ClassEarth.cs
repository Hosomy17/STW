using UnityEngine;
using System.Collections;

public class ClassEarth : ClassGeneric
{
    public ControllerEarth controllerEarth;
    public ClassTrashCan trashCan;
    void Awake()
    {
        controllerEarth = new ControllerEarth();
    }

    void Start()
    {
        trashCan = GameObject.Find("Main/Player/Trash Can").GetComponent<ClassTrashCan>();
        Blink();
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        if(c.gameObject.CompareTag("Iten"))
        {
            trashCan.controllerTrashCan.Hurt();
            controllerEarth.Hurt();

            BehaviourAnimation.Float(gameObject, "Life", trashCan.life);
        }
    }
    private void Blink()
    {
        BehaviourAnimation.Play(gameObject, "Blink");

        float n = Random.Range(5f,15f);
        Invoke("Blink",n);
    }
}
