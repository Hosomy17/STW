using UnityEngine;
using System.Collections;

public static class FacadeTrashCan
{
    public static void Walk(ClassTrashCan dataTrashCan, int direction)
    {
        BehaviourPhysics.Turn(dataTrashCan.transform.parent.gameObject, Vector3.forward * direction, dataTrashCan.moveSpeed);
        BehaviourAnimation.Play(dataTrashCan.gameObject, "Walk");
        //BehaviourSound.Play("Walk");
    }

    public static void Score(ClassTrashCan dataTrashCan)
    {

    }

    public static void Idle(ClassTrashCan dataTrashCan)
    {
        BehaviourAnimation.Play(dataTrashCan.gameObject, "Idle");
    }

    public static void ChangeColor(ClassTrashCan dataTrashCan, string color)
    {
        dataTrashCan.color = color;
        RuntimeAnimatorController AnimatorController = Resources.Load("Animations/Trash Can/" + color + "/"+ color) as RuntimeAnimatorController;
        BehaviourAnimation.ChangeAnimatorController(dataTrashCan.gameObject, AnimatorController);
    }

    public static void Hurt(ClassTrashCan dataTrashCan)
    {
        dataTrashCan.lifes--;
    }
}
