using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        name = "Cube";
        className = "Mage unit";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void PrintData()//POLYMORPHISM
    {
        dataDisplay.text = "My name is " + name + " and I am an " + className + ". I am best as a support personel for my fellow allies.";
    }
}