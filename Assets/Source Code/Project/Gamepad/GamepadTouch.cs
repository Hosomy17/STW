using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GamepadTouch : GamepadGeneric
{
    private ControllerGeneric controller;
    private Dictionary<string, object> input;

    void Awake()
    {
        controller = new ControllerTrashCan();
        input = new Dictionary<string, object>();
        input.Add("Name",null);
        input.Add("Axis", null);
    }

    void Update()
    {
        input["Name"] = "Coordinates";
        input["Axis"] = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        controller.SendInput(input);
    }

}
