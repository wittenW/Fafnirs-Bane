using UnityEngine;
using System.Collections;
using UnityEditor;

public class LoadLevel : MonoBehaviour
{
        
    public string Scene;
    public BoxCollider2D door;
    
    public GameObject innerPortal;
    public GameObject outerPortal;
    
    // Use this for initialization
    void Start()
    {
        Log("Door Position is " + door.transform.position);
        
        // If no scene is set in inspector, initialize to curren scene
        if (string.IsNullOrEmpty(Scene))
        {
            Scene = Application.loadedLevelName;
            Log("Set initial scene");
        }
    }
    
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        Log("Something has entered this zone. " + other.name);
        Log(Application.loadedLevelName);
        if (Application.loadedLevelName.Equals(Scene))
        {
            Log("We're in the same scene.");
            other.transform.position = door.transform.position;
        }
            
        //Application.LoadLevel(Scene);
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        Log("Something has exited this zone. " + other.name);
    }
    
    void OnTriggerStay2D(Collider2D other)
    {
        //Debug.Log("Something has stayed this zone. " + other.name);
    }
    
    void Log(string extra)
    {
        string sb = this.name;
        sb += " " + extra;
        Debug.Log(sb);
    }
}

        
    

