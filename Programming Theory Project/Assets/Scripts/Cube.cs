using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shapes
{
    protected override void SetName()
    {
        Name = "Cube";
    }
    protected override void DisplayText()
    {
        Debug.Log(Name);
    }
}
