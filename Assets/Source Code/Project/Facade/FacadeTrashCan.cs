using UnityEngine;
using System.Collections;

public static class FacadeTrashCan
{
    public static void Walk(ClassTrashCan dataTrashCan, int direction)
    {
        BehaviourPhysics.Turn(dataTrashCan.transform.parent.gameObject, Vector3.forward * direction, dataTrashCan.moveSpeed);
        //BehaviourAnimation.Play(dataTrashCan.gameObject, "Walk");
        //BehaviourSound.Play("Walk");
    }

    public static void Score(ClassTrashCan dataTrashCan)
    {
        dataTrashCan.life += 1 * 5;

        if (dataTrashCan.life > 100)
            dataTrashCan.life = 100;

        BehaviourSound.Play("SFX/Point");
    }

    public static void Idle(ClassTrashCan dataTrashCan)
    {
        //BehaviourAnimation.Play(dataTrashCan.gameObject, "Idle");
    }

    public static void ChangeColor(ClassTrashCan dataTrashCan, string color)
    {
        BehaviourAnimation.Play(dataTrashCan.gameObject, "Color_"+color);
    }

    public static void Hurt(ClassTrashCan dataTrashCan)
    {
        dataTrashCan.life -= 1 * 5;
    }
}
