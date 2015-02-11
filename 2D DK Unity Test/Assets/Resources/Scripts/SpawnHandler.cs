using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnHandler : MonoBehaviour
{

    public static bool MoveToSpawn(List<GameObject> playerList, string spawnName)
    {
        // Find the specified spawn point and move all player characters there
        var spawn = SpawnHandler.GetSpawnPoint(spawnName);
        foreach (var p in playerList)
        {
            Debug.Log("Moving Character " + p.name + " to " + spawn.name);
            p.transform.position = spawn.transform.position;
        }
        return true;
    }

    /// <summary>
    /// Creates a list of all objects with the SpawnPoint tag, then checks each item for the
    /// case insensitive name passed from a trigger box. If no name is found, it returns the
    /// default spawn point for the level.
    /// </summary>
    /// <returns>The spawn point.</returns>
    public static GameObject GetSpawnPoint(string spawnName)
    {
        if (spawnName != null)
        {
            var spawns = GameObject.FindGameObjectsWithTag("SpawnPoint");
            
            foreach (var s in spawns)
            {
                if (s.name.ToLower().Equals(spawnName))
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
