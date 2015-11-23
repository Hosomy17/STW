using UnityEngine;
using System.Collections;

public static class BehaviourAnimation
{
    public static void Play(GameObject gameObject, string animation)
    {
        gameObject.GetComponent<Animator>().Play(animation);
    }

    public static void Trigger(GameObject gameObject, string trigger)
    {
        gameObject.GetComponent<Animator>().SetTrigger(trigger);
    }

    public static void ChangeAvatar(GameObject gameObject, RuntimeAnimatorController runtimeAnimatorController)
    {

        gameObject.GetComponent<Animator>().runtimeAnimatorController = runtimeAnimatorController;
    }
}
