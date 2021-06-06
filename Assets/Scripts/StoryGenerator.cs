using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryGenerator : MonoBehaviour
{
    // Start is called before the first frame update
   [SerializeField]
    public List<Dictionary<string, object>> data;
   
   [SerializeField]
    private string myText;
    [SerializeField]
    private Color myColour;
    
    [SerializeField]
    private TextLogControl logControl;

   
    void Start()
    {
        data = CSVReader.Read("LogDatabase");
        //StartCoroutine(delay());
        //GetSentence();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    public string GetSentence()
    {
        string ReturnSentence = "";
        int rng;
        //Debug.Log(data.Count);
        //for(int i = 0; i < 1;)
       //{
            rng = Random.Range(1,data.Count);
            ReturnSentence = data[rng]["name"].ToString();
                         
            rng = Random.Range(1,data.Count);
            ReturnSentence += " " + data[rng]["verb"].ToString() + " ";
            
            rng = Random.Range(1,data.Count);
            ReturnSentence += " " + data[rng]["name"].ToString() + ". ";
            
            rng = Random.Range(1,data.Count);
            ReturnSentence += data[rng]["phrase"].ToString() + ".";
            
            //rng = Random.Range(10,31);
            //delay();
            //Debug.Log(ReturnSentence);
            myText = ReturnSentence;
            myColour = Color.white;
            LogText();
        //}

        return ReturnSentence;
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(30);
    }
      
     public void LogText()
    {
        logControl.LogText(myText, myColour);
    }
    
        
    
}
