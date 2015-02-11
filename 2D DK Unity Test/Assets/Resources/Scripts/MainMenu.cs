using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MainMenu : MonoBehaviour
{
    
    public void StartButtonClick()
    {
        Debug.Log("Start button Clicked");

        StartGame();
    }

    private void StartGame()
    {
        Debug.Log("Starting game");
        DontDestroyOnLoad(GameInstance.Instance);
        DontDestroyOnLoad(UIInterfaceManager.Instance);
        GameInstance.Instance.StartState();
    }

}
