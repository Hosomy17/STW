using UnityEngine;
using System.Collections;

public class DataTrashCan : DataObjectGeneric
{
    public float moveSpeed;
    public string color;
    private ParticleSystem particleSystem;

    void Awake()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        particleSystem.startRotation = -transform.rotation.eulerAngles.z * Mathf.Deg2Rad;
    }
}
