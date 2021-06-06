using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    
    public GameObject globaluimanager;
    private UIManager localuimanager;
    
    // Start is called before the first frame update
    void Start()
    {
        localuimanager = globaluimanager.GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
       Debug.Log(localuimanager.teststring);
       localuimanager.teststring = localuimanager.teststring + "\n testtwo";
    }
}
