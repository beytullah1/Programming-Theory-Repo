using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shapes
{
    protected override void SetName()
    {
        Name = "Cylinder";
    }
    protected override void DisplayText()
    {
        Debug.Log(Name);
    }
}
