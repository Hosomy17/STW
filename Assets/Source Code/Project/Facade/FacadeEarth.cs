using UnityEngine;
using System.Collections;

public static class FacadeEarth
{
    public static void Hurt(ClassEarth classEarth)
    {
        GameObject camera = GameObject.Find("Game Camera/Effect");
        BehaviourAnimation.Play(classEarth.gameObject, "Hurt");
        BehaviourAnimation.Play(camera, "Hurt");

        BehaviourSound.Play("SFX/Explosion");

        Camera.main.GetComponent<Shaker>().Shake(40f, 1);
    }
}
