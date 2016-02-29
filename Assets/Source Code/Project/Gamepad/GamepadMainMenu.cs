using UnityEngine;
using System.Collections;

public class GamepadMainMenu : GamepadGeneric
{
    void Update()
    {

    }
    void OnMouseDown()
    {
        if(isActiveAndEnabled)
            GameObject.FindGameObjectWithTag("SceneManager").GetComponent<SceneManagerGame>().StartGame();
    }
}
