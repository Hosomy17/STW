using UnityEngine;
using System.Collections;

public static class FacadeTrashCan
{
    public static void Walk(DataTrashCan dataTrashCan, int direction)
    {
        BehaviourPhysics.Turn(dataTrashCan.transform.parent.gameObject, Vector3.forward * direction, dataTrashCan.moveSpeed);
        BehaviourAnimation.Play(dataTrashCan.gameObject, "Walk");
        //BehaviourSound.Play("Walk");
    }

    public static void Score(DataTrashCan dataTrashCan)
    {

    }

    public static void Idle(DataTrashCan dataTrashCan)
    {
        BehaviourAnimation.Play(dataTrashCan.gameObject, "Idle");
    }

    public static void ChangeColor(DataTrashCan dataTrashCan, string color)
    {
        RuntimeAnimatorController AnimatorController = Resources.Load("Animations/Trash Can/" + color + "/"+ color) as RuntimeAnimatorController;
        Debug.Log("Animations/Trash Can/" + color + "/"+ color);
        BehaviourAnimation.ChangeAnimatorController(dataTrashCan.gameObject, AnimatorController);
    }
}
