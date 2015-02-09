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

        StartGame();
    }

    private void StartGame()
    {
        Debug.Log("Starting game");
        DontDestroyOnLoad(GameInstance.Instance);
        GameInstance.Instance.StartState();
    }

}
