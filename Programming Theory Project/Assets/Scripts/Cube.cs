using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shapes //Inheritance
{
    protected override void SetName() //Polymorphism
    {
        Name = "Cube";
    }
}
