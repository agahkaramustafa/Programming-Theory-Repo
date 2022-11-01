using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() 
    {
        if (!TextToDisplay.isActiveAndEnabled)
        {
            DisplayText(6, "Square");
        }
    }
}
