using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunLog : MonoBehaviour
{
    /*[SerializeField]
    private string myText;
    [SerializeField]
    private Color myColour;
    
    [SerializeField]
    private TextLogControl logControl;

    public void LogText()
    {
        logControl.LogText(myText, myColour);
    }*/

    [SerializeField]
    private StoryGenerator StoryControl;

    public void GenText()
    {
        StoryControl.GetSentence();
        
    }
    
}
