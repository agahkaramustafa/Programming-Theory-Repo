using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : Shape // INHERITANCE
{
    public Color MaterialColor { get; private set; } // ENCAPSULATION
    public string ObjectName { get; private set; } // ENCAPSULATION

    // Start is called before the first frame update
    void Start()
    {
        MaterialColor = GetComponent<MeshRenderer>().material.color;
        ObjectName = name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() 
    {
        if (!TextToDisplay.isActiveAndEnabled)
        {
            // ABSTRACTION
            DisplayText(6, name);
        }
    }

    public override void DisplayText(float timeOnDisplay, string shapeName) 
    {
        // POLYMORPHISM
        TextToDisplay.color = MaterialColor;
        base.DisplayText(timeOnDisplay, shapeName);
    }
}
