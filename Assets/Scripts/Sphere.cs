using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        name = "Sphere";
        className = "Berserk melee unit";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void PrintData()//POLYMORPHISM
    {
        dataDisplay.text = "My name is " + name + " and I am a " + className + ". My stength lies in my ability to fight close quarters.";
    }
}
