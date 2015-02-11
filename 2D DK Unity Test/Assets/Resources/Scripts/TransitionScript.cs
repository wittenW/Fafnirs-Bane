using UnityEngine;
using System.Collections;

public class TransitionScript : MonoBehaviour
{
    public string LinkedScene;

    [SerializeField]
    public string
        LinkedSpawn = "Spawn";

    void OnTriggerEnter2D(Collider2D other)
    {
        GameInstance.NextSpawn = LinkedSpawn;
        Application.LoadLevel(LinkedScene);
    }
}
