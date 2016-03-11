using UnityEngine;
using System.Collections;

public class ClassTrashCan : ClassGeneric
{
    public float moveSpeed;
    public int lifes;
    public string color;
    public ControllerTrashCan controllerTrashCan;
    private ParticleSystem particles;

    void Awake()
    {
        lifes = 0;
        particles = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        particles.startRotation = -transform.rotation.eulerAngles.z * Mathf.Deg2Rad;
    }
}
