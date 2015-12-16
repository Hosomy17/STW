using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ControllerBotton : ControllerGeneric
{
    private DataBotton dataBotton;
    private DataTrashCan dataTrashCan;

    public ControllerBotton()
    {
        dataTrashCan = GameObject.Find("Player/Trash Can").GetComponent<DataTrashCan>();
        dataBotton = GameObject.Find("Button").GetComponent<DataBotton>();
    }

    public override void SendInput(Dictionary<string, object> input)
    {
        
    }

    public void Click()
    {
        string color = dataBotton.Colors;
        FacadeButton.DownClick(dataBotton, color);
        FacadeTrashCan.ChangeColor(dataTrashCan, color);
    }

    public void Release()
    {

    }
}
