using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        name = "Capsule";
        className = "Archer unit";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void PrintData() //POLYMORPHISM
    {
        dataDisplay.text = "My name is " + name + " and I am an " + className + ". I fight best at long ranges to pick off my enemies.";
    }
}