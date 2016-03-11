using UnityEngine;
using System.Collections;

public static class FacadeEarth
{
    public static void Hurt(ClassEarth classEarth)
    {
        BehaviourAnimation.Play(classEarth.gameObject, "Hurt");
        BehaviourAnimation.Play(Camera.main.gameObject, "Hurt");
        Camera.main.GetComponent<Shaker>().Shake(40f, 1);
    }
}
