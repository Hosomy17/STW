using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ControllerTrashCan : ControllerGeneric
{
    private ClassTrashCan classTrashCan;
    private SceneManagerGame sceneManagerGame;

    public ControllerTrashCan()
    {
        classTrashCan = GameObject.Find("Player/Trash Can").GetComponent<ClassTrashCan>();
        sceneManagerGame = GameObject.FindGameObjectWithTag("SceneManager").GetComponent<SceneManagerGame>();
        classTrashCan.controllerTrashCan = this;
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

    public void Hurt()
    {
        FacadeTrashCan.Hurt(classTrashCan);
        if (classTrashCan.lifes <= 0)
            sceneManagerGame.GameOver();
    }

    public void Walk(Dictionary<string, object> input)
    {
        
        Vector3 mouseCoordinates = (Vector3)input["Axis"];
        string state = (string)input["State"];
        if (state == "Hold" && mouseCoordinates.y > 0.13)
        {
            //rotation
            float r = classTrashCan.transform.parent.rotation.eulerAngles.z;
            //Right
            if (mouseCoordinates.x > 0.5 && r > 230)
                FacadeTrashCan.Walk(classTrashCan, 1);
            //Left
            else if (mouseCoordinates.x < 0.5 && r < 310)
                FacadeTrashCan.Walk(classTrashCan, -1);
            else
                FacadeTrashCan.Idle(classTrashCan);
        }
        else
            FacadeTrashCan.Idle(classTrashCan);
    }
}
