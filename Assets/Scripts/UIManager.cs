using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text eventtext;
    public Button option1;
    public Button option2;
    public string teststring;
    
    // Start is called before the first frame update
    void Start()
    {
        teststring = "testoneone";   
        

    }
     void Update()
    {
        eventtext.text = teststring;
        
        

    }

    
}
