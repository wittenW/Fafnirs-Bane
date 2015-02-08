using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MainMenu : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
	
    }
	
    // Update is called once per frame
    void Update()
    {
	
    }
    
    public void StartButtonClick()
    {
        Debug.Log("Start button Clicked");
        Application.LoadLevel("Test Scene");
//        GameObject[] components = this.GetComponentsInParent;
//        
//        foreach (var g in components)
//            Debug.Log(g.name);
    }
}
