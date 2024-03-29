﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class ControllerTrashCan : ControllerGeneric
{
    private ClassTrashCan classTrashCan;
    private ScriptGame scriptGame;

    private GameObject earth;

    public ControllerTrashCan()
    {
        classTrashCan = GameObject.Find("Player/Trash Can").GetComponent<ClassTrashCan>();
        scriptGame = GameObject.FindGameObjectWithTag("SceneManager").GetComponent<ScriptGame>();
        classTrashCan.controllerTrashCan = this;

        earth = GameObject.Find("Earth");
    }

    public override void TrackObject(GameObject gameObject)
    {
        classTrashCan = gameObject.GetComponent<ClassTrashCan>();
        scriptGame = gameObject.GetComponent<ScriptGame>();
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
        if (classTrashCan.life <= 0)
            scriptGame.GameOver();
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
            if (mouseCoordinates.x > 0.5 && r > 200)
                FacadeTrashCan.Walk(classTrashCan, 1);
            //Left
            else if (mouseCoordinates.x < 0.5 && r < 340)
                FacadeTrashCan.Walk(classTrashCan, -1);
            else
                FacadeTrashCan.Idle(classTrashCan);
        }
        else
            FacadeTrashCan.Idle(classTrashCan);
    }

    public void Point()
    {
        FacadeTrashCan.Score(classTrashCan);

        BehaviourAnimation.Float(earth,"Life",classTrashCan.life);
    }
}
