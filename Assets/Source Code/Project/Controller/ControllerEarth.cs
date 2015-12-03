using UnityEngine;
using System.Collections;

public class ControllerEarth : ControllerGeneric
{
    private DataEarth dataEarth;

    public ControllerEarth()
    {
        dataEarth = GameObject.Find("Background/Earth").GetComponent<DataEarth>();
        dataEarth.controllerEarth = this;
    }

    public void Hurt()
    {
        FacadeEarth.Hurt(dataEarth);
    }

    public override void SendInput(System.Collections.Generic.Dictionary<string, object> input)
    {
        throw new System.NotImplementedException();
    }
}
