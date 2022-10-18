using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shapes
{
    protected override void SetName()
    {
        Name = "Sphere";
    }
    protected override void DisplayText()
    {
        Debug.Log(Name);
    }
}
