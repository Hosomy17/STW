using UnityEngine;
using System.Collections;

public class GamepadMainMenu : GamepadGeneric
{
    void OnMouseDown()
    {
        GameObject.FindGameObjectWithTag("SceneManager").GetComponent<SceneManagerGame>().StartGame();
    }
}
