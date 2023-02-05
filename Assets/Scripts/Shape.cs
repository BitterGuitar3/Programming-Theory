using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Shape : MonoBehaviour
{
    protected string name { get; set; }
    protected string className { get; set; }
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
    public virtual void PrintData()
    {
        dataDisplay.text = "My name is " + name;
    }
}
