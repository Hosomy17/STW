using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ControllerTrashCan : ControllerGeneric
{
    private DataTrashCan dataTrashCan;

    public ControllerTrashCan()
    {
        dataTrashCan = GameObject.Find("Player/Trash Can").GetComponent<DataTrashCan>();
    }

    public override void SendInput(Dictionary<string, object> input)
    {
        string name = (string)input["Name"];
        switch (name)
        {
            case "Coordinates":
                Walk(input);
                break;
        }
    }

    public void Walk(Dictionary<string, object> input)
    {
        Vector3 mouseCoordinates = (Vector3)input["Axis"];
        string state = (string)input["State"];
        if (state == "Hold")
        {
            //rotation
            float r = dataTrashCan.transform.parent.rotation.eulerAngles.z;
            //Right
            if (mouseCoordinates.x > 0.5 && r > 230)
                FacadeTrashCan.Walk(dataTrashCan, 1);
            //Left
            else if (mouseCoordinates.x < 0.5 && r < 310)
                FacadeTrashCan.Walk(dataTrashCan, -1);
            else
                FacadeTrashCan.Idle(dataTrashCan);
        }
        else
            FacadeTrashCan.Idle(dataTrashCan);
    }
}
