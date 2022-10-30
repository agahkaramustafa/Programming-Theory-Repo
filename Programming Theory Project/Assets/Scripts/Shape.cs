using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shape : MonoBehaviour
{
    public TextMeshProUGUI TextToDisplay;
    public float TimeOnDisplay { get; set ; }
    public string ShapeOnDisplay { get; set ; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void DisplayText(float timeOnDisplay, string shapeName)
    {
        TimeOnDisplay = timeOnDisplay;
        ShapeOnDisplay = shapeName;
        StartCoroutine(nameof(enableDisableText));
    }

    IEnumerator enableDisableText()
    {
        TextToDisplay.enabled = true;
        TextToDisplay.text = "This is a " + ShapeOnDisplay + " and I will close this text in " + TimeOnDisplay.ToString() + " seconds.";
        yield return new WaitForSeconds(TimeOnDisplay);
        TextToDisplay.enabled = false;
    }
}