using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameInstance : MonoBehaviour
{

    private static GameInstance _instance;

    /// <summary>
    /// Creates an instance of GameInstance as a gameobject if an instance does not exist
    /// </summary>
    public static GameInstance Instance
    {
        get
        {
            if (_instance == null)
                _instance = new GameObject("GameInstanceManager").AddComponent<GameInstance>();
            
            return _instance;
        }
    }

    [SerializeField]
    public string
        activeLevel;

    /// <summary>
    /// The name of a spawn point in the next scene, to which the player and party will be moved on scene load
    /// </summary>
    public static string NextSpawn
    {
        set { _nextSpawn = value.ToLower(); }
    }
    private static string _nextSpawn;
    
    /// <summary>
    /// The player characters.
    /// </summary>
    [SerializeField]
    private List<GameObject>
        PlayerCharacters;


    public void StartState()
    {
        // Set up the initial player Charater object
        GameObject DK = (GameObject)Instantiate(Resources.Load("Characters/Donkey Kong"));
        PlayerCharacters = new List<GameObject>();

        DontDestroyOnLoad(DK);
        PlayerCharacters.Add(DK);

        NextSpawn = "spawnPoint";


        Application.LoadLevel("Test Scene 1");
    }

    /// <summary>
    /// Raises the level was loaded event.
    /// </summary>
    /// <param name="level">Level.</param>
    void OnLevelWasLoaded(int level)
    {
        // The name of the scene that's loaded, can be used in a map or menu to tell us where we are
        activeLevel = Application.loadedLevelName;
        Debug.Log("Loaded in level " + activeLevel);

        SpawnHandler.MoveToSpawn(PlayerCharacters, _nextSpawn);
    }


    
}
