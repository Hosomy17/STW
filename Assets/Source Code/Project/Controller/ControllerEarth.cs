using UnityEngine;
using System.Collections;

public class ControllerEarth : ControllerGeneric
{
    private ClassEarth classEarth;

    public ControllerEarth()
    {
        classEarth = GameObject.Find("Background/Earth").GetComponent<ClassEarth>();
        classEarth.controllerEarth = this;
    }

    public void Hurt()
    {
        FacadeEarth.Hurt(classEarth);
    }

    public override void SendInput(System.Collections.Generic.Dictionary<string, object> input)
    {
        throw new System.NotImplementedException();
    }
}
