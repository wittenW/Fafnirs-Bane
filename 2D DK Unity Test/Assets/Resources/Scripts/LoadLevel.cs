using UnityEngine;
using System.Collections;
using UnityEditor;

public class LoadLevel : MonoBehaviour
{
    public BoxCollider2D door;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.position = door.transform.position;
    }
}

        
    

