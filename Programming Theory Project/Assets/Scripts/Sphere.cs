using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shapes //Inheritance
{
    protected override void SetName() //Polymorphism
    {
        Name = "Sphere";
    }
}
