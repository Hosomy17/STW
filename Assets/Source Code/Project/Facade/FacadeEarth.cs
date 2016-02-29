using UnityEngine;
using System.Collections;

public static class FacadeEarth
{
    public static void Hurt(ClassEarth dataEarth)
    {
        BehaviourAnimation.Play(dataEarth.gameObject, "Hurt");
        BehaviourAnimation.Play(Camera.main.gameObject, "Hurt");
        Camera.main.GetComponent<Shaker>().Shake(40f, 1);
    }
}
