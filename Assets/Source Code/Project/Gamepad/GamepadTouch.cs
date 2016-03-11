using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GamepadTouch : GamepadGeneric
{
    private ControllerTrashCan ctrlTrashCan;
    private Dictionary<string, object> input;

    void Awake()
    {
        ctrlTrashCan = new ControllerTrashCan();
        input = new Dictionary<string, object>();
        input.Add("Name", null);
        input.Add("Axis", null);
        input.Add("State", null);
    }

    void Update()
    {
        if(Input.GetMouseButton(0))
            input["State"] = "Hold";
        else
            input["State"] = "NULL";

        input["Name"] = "Coordinates";
        input["Axis"] = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        ctrlTrashCan.SendInput(input);
    }
}
