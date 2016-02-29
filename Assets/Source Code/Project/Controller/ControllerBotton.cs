using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ControllerBotton : ControllerGeneric
{
    private ClassBotton classBotton;
    private ClassTrashCan classTrashCan;

    public ControllerBotton()
    {
        classTrashCan = GameObject.Find("Player/Trash Can").GetComponent<ClassTrashCan>();
        classBotton = GameObject.Find("Button").GetComponent<ClassBotton>();
    }

    public override void SendInput(Dictionary<string, object> input)
    {
        
    }

    public void Click()
    {
        string color = classBotton.Colors;
        FacadeButton.DownClick(classBotton, color);
        FacadeTrashCan.ChangeColor(classTrashCan, color);
    }

    public void Release()
    {

    }
}
