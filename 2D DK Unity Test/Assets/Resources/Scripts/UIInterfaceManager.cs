using UnityEngine;
using System.Collections;

public class UIInterfaceManager : MonoBehaviour
{
    public static GameObject inventoryMenu;


    // Use this for initialization
    void Start()
    {
        if (inventoryMenu == null)
        {
            inventoryMenu = (GameObject)Instantiate(Resources.Load("UI/Interface"));
            Debug.Log("Made a new ui instance");
        }
            
    }
	
    // Update is called once per frame
    void Update()
    {
	
    }
    
    public void InventoryButtonClick()
    {
        
    }
}
