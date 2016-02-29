using UnityEngine;
using System.Collections;

public class GamepadPause : GamepadGeneric
{
    void OnMouseDown()
    {
        if (isActiveAndEnabled)
            GameObject.FindGameObjectWithTag("SceneManager").GetComponent<SceneManagerGame>().Pause();
    }
}
