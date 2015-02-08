using UnityEngine;
using System.Collections;

public class GameInstance : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(this);
    }
	
    // Update is called once per frame
    void FixedUpdate()
    {
        var scene = Application.loadedLevelName;
        Debug.Log(scene);
        if (!scene.Equals(Application.loadedLevelName))
            Debug.Log("New Scene");
    }
}
