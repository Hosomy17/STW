using UnityEngine;
using System.Collections;

public static class FacadeTrashCan
{
    public static void Walk(DataTrashCan dataTrashCan, int direction)
    {
        BehaviourPhysics.Turn(dataTrashCan.transform.parent.gameObject, Vector3.forward * direction, dataTrashCan.moveSpeed);
        //BehaviourAnimation.Play(dataTrashCan.gameObject, "Walk");
        //BehaviourSound.Play("Walk");
    }

    public static void Score(DataTrashCan dataTrashCan)
    {
        BehaviourAnimation.Play(dataTrashCan.gameObject, "Walk");
        BehaviourSound.Play("Score");
    }
}
