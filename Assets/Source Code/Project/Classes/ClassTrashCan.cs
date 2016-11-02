using UnityEngine;
using System.Collections;

public class ClassTrashCan : ClassGeneric
{
    public float moveSpeed;
    public float life;
    public ControllerTrashCan controllerTrashCan;
    private ParticleSystem particles;

    void Awake()
    {
        life = 80;
        particles = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        particles.startRotation = -transform.rotation.eulerAngles.z * Mathf.Deg2Rad;
    }
}
