using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Shape : MonoBehaviour
{
    protected string name { get; set; } //Encapulation
    protected string className { get; set; } //Encapulation
    public TextMeshProUGUI dataDisplay;

    private void Start()
    {

    }

    public void Update()
    {

    }

    public void OnMouseDown()
    {
        PrintData();
    }

    //POLYMORPHISM. When implemented in each child class, it will print something different
    public virtual void PrintData()//ABSTRACTION
    {
        dataDisplay.text = "My name is " + name;
    }
}
