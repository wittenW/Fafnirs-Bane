using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameInstance : MonoBehaviour
{

    private static GameInstance _instance;

    [SerializeField]
    public string
        activeLevel;

    private static string _spawnName;
    
    /// <summary>
    /// The player characters.
    /// </summary>
    [SerializeField]
    private List<GameObject>
        PlayerCharacters;

    private GameObject player;
    
    
    /// <summary>
    /// Creates an instance of gamestate as a gameobject if an instance does not exist
    /// </summary>
    public static GameInstance Instance
    {
        get
        {
            if (_instance == null)
                _instance = new GameObject("GameInstance").AddComponent<GameInstance>();
            
            return _instance;
        }
    }
	
    public static string NextSpawn
    {
        set { _spawnName = value.ToLower(); }
    }


    public void StartState()
    {
        // Set up the initial player Charater object
        GameObject DK = (GameObject)Instantiate(Resources.Load("Characters/Donkey Kong"));
        PlayerCharacters = new List<GameObject>();

        DontDestroyOnLoad(DK);
        player = DK;
        PlayerCharacters.Add(DK);

        NextSpawn = "spawnPoint";


        Application.LoadLevel("Test Scene 1");

        
        Instantiate(Resources.Load("UI/Interface"));
    }


    void OnLevelWasLoaded(int level)
    {
        // The name of the scene that's loaded, can be used in a map or menu to tell us where we are
        activeLevel = Application.loadedLevelName;
        Debug.Log("Loaded in level " + activeLevel);


        // Find the specified spawn point and move all player characters there
        var spawn = GetSpawnPoint();
        foreach (var p in PlayerCharacters)
        {
            Debug.Log("Moving Character " + p.name + " to " + spawn.name);
            p.transform.position = spawn.transform.position;
        }
        player.transform.position = spawn.transform.position;

    }

    /// <summary>
    /// Creates a list of all objects with the SpawnPoint tag, then checks each item for the
    /// case insensitive name passed from a trigger box. If no name is found, it returns the
    /// default spawn point for the level.
    /// </summary>
    /// <returns>The spawn point.</returns>
    GameObject GetSpawnPoint()
    {
        if (_spawnName != null)
        {
            var spawns = GameObject.FindGameObjectsWithTag("SpawnPoint");
            
            foreach (var s in spawns)
            {
                if (s.name.ToLower().Equals(_spawnName))
                {
                    Debug.Log("Found spawn point " + s.name);
                    foreach (Transform t in s.transform)
                    {
                        if (t.name.Equals("spawnPoint"))
                            return t.gameObject;
                    }
                }
            }
        }
        Debug.LogWarning("Returning default spawn point");
        return GameObject.Find("spawnPoint");
    }


    
}
