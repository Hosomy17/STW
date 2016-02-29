using UnityEngine;
using System.Collections;

public class ClassTrashCan : ClassGeneric
{
    public float moveSpeed;
    public int lifes;
    public string color;
    public ControllerTrashCan controllerTrashCan;
    private ParticleSystem particleSystem;

    void Awake()
    {
        lifes = 0;
        particleSystem = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        particleSystem.startRotation = -transform.rotation.eulerAngles.z * Mathf.Deg2Rad;
    }
}
