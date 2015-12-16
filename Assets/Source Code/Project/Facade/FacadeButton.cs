using UnityEngine;
using System.Collections;

public static class FacadeButton
{

    public static void DownClick(DataBotton dataBotton, string color)
    {
        RuntimeAnimatorController AnimatorController = Resources.Load("Animations/Button/" + color + "/Button") as RuntimeAnimatorController;
        BehaviourAnimation.ChangeAnimatorController(dataBotton.gameObject, AnimatorController);
    }

    public static void UpClick()
    {

    }
}
